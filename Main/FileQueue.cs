namespace Main
{
    class FileQueue
    {
        public bool Enable { get; set; } = true;
        public string FilePath { get; set; }
        public string Engine { get; set; }
        public string Stem { get; set; }
        public string OutputBitrate { get; set; }
        public string OutputFormat { get; set; }
        public int Offset { get; set; }
        public int Duration { get; set; }
        public bool UseMWF { get; set; }
    }
}
