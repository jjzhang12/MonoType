using System;

namespace ClassLibrary1
{
    public struct Struct1
    {
        public int int1;
        public double double1;
        public string string1;

        public int Int1 { get; set; }
        public double Double1 { get; set; }
        public string String1 { get; set; }

        public int GetInt() => 1;
        public double GetDouble() => 1;

        public string GetString() => string.Empty;

    }
}
