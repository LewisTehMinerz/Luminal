﻿using System.IO;
using System.Text.Json;

namespace Luminal.Configuration
{
    public class LuminalConfigLoader
    {
        public static LuminalConfig LoadConfig(string Path)
        {
            var f = File.ReadAllText(Path);
            var js = JsonSerializer.Deserialize<LuminalConfig>(f);
            return js;
        }
    }
}