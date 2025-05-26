﻿using System;

/*namespace CompressionStrategyPattern
{
    public abstract class CompressionStrategy
    {
        public abstract void Compress(string inputPath, string outputPath);
    }

    public class ZipCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing {inputPath} to {outputPath} using ZIP");
        }
    }

    public class RarCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing {inputPath} to {outputPath} using RAR");
        }
    }

    public class Compressor
    {
        private CompressionStrategy _strategy;
        public Compressor(CompressionStrategy strategy) => _strategy = strategy;
        public void SetStrategy(CompressionStrategy strategy) => _strategy = strategy;
        public void Compress(string inputPath, string outputPath) => _strategy.Compress(inputPath, outputPath);
    }

    class Program
    {
        static void Main()
        {
            var compressor = new Compressor(new ZipCompression());
            compressor.Compress("file.txt", "file.zip");

            compressor.SetStrategy(new RarCompression());
            compressor.Compress("file.txt", "file.rar");
        }
    }
}*/