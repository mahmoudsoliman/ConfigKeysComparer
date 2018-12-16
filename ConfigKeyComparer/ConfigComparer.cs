using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConfigKeyComparer
{
    public class ConfigComparer
    {
        private string _oldConfigPath;
        private string _newConfigPath;
        private string commentText = "<!--";
        private string keyRegex = "key=\"([^\"]*)\"";
        private string valueRegex = "value=\"(.*)\"";

        public void SetOldConfigPath(string oldConfigPath)
        {
            _oldConfigPath = oldConfigPath;
        }

        public void SetNewConfigPath(string newConfigPath)
        {
            _newConfigPath = newConfigPath;
        }

        public List<ConfigCompareResult> Compare()
        {
            string oldConfigs;
            string newConfigs;
            try
            {
                oldConfigs = ReadFile(_oldConfigPath);
            }
            catch (Exception)
            {
                return null;
            }
            try
            {
                newConfigs = ReadFile(_newConfigPath);
            }
            catch (Exception)
            {

                return null;
            }
            List<ConfigCompareResult> result = new List<ConfigCompareResult>();
            List<string> oldConfigsList = oldConfigs.Split('\n').ToList();
            List<string> newConfigsList = newConfigs.Split('\n').ToList();
            Dictionary<string, string> oldConfigsDictionary = new Dictionary<string, string>();
            Dictionary<string, string> newConfigsDictionary = new Dictionary<string, string>();
            foreach(string config in oldConfigsList)
            {
                if (config.Contains(commentText))
                    continue;
                if(config.Contains("key") && config.Contains("value"))
                {
                    var keyMatch = Regex.Match(config, keyRegex);
                    var valueMatch = Regex.Match(config, valueRegex);
                    string key = keyMatch.Groups[1].Value;
                    string value = valueMatch.Groups[1].Value;
                    if(!oldConfigsDictionary.ContainsKey(key))
                        oldConfigsDictionary.Add(key, value);
                    else
                    {
                        result.Add(new ConfigCompareResult
                        {
                            Name = key,
                            OldValue = value,
                            NewValue = "",
                            Status = Helpers.ResultType.DUPLICATE_OLD
                        });
                    }
                }
            }
            foreach (string config in newConfigsList)
            {
                if (config.Contains(commentText))
                    continue;
                if (config.Contains("key") && config.Contains("value"))
                {
                    var keyMatch = Regex.Match(config, keyRegex);
                    var valueMatch = Regex.Match(config, valueRegex);
                    string key = keyMatch.Groups[1].Value;
                    string value = valueMatch.Groups[1].Value;
                    if(!newConfigsDictionary.ContainsKey(key))
                        newConfigsDictionary.Add(key, value);
                    else
                    {
                        result.Add(new ConfigCompareResult
                        {
                            Name = key,
                            OldValue = "",
                            NewValue = value,
                            Status = Helpers.ResultType.DUPLICATE_NEW
                        });
                        continue;
                    }
                    if(oldConfigsDictionary.ContainsKey(key))
                    {
                        if (oldConfigsDictionary[key] != value)
                        {
                            result.Add(new ConfigCompareResult
                            {
                                Name = key,
                                OldValue = oldConfigsDictionary[key],
                                NewValue = value,
                                Status = Helpers.ResultType.DIFFERENT_VALUE
                            });
                        }
                    }
                    else
                    {
                        result.Add(new ConfigCompareResult
                        {
                            Name = key,
                            OldValue = "",
                            NewValue = value,
                            Status = Helpers.ResultType.NEW_ONLY
                        });
                    }
                }
            }
            foreach(var config in oldConfigsDictionary)
            {
                if(!newConfigsDictionary.ContainsKey(config.Key))
                {
                    result.Add(new ConfigCompareResult
                    {
                        Name = config.Key,
                        OldValue = config.Value,
                        NewValue = "",
                        Status = Helpers.ResultType.OLD_ONLY
                    });
                }
            }
            return result;
        }

        public string ReadFile(string fileName)
        {
            string data;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            using (StreamReader sr = new StreamReader(fs))
            {
                data = sr.ReadToEnd();
            }
            return data;
        }
    }
}
