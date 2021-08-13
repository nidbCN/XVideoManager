using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace XVideoManager.Core.Entities
{
    public class VideoEntity
    {
        public VideoEntity(string code, string title, string banner)
        {
            Code = code
                ?? throw new ArgumentNullException(nameof(code));
            Title = title
                ?? throw new ArgumentNullException(nameof(title));
            Banner = banner
                ?? throw new ArgumentNullException(nameof(banner));
        }

        /// <summary>
        /// 番号
        /// </summary>
        [NotNull]
        public string Code { get; set; }

        [NotNull]
        public string Title { get; set; }

        [NotNull]
        public string Banner { get; set; }

        [AllowNull]
        public string? Description { get; set; }

        [AllowNull]
        public IList<string>? Stars { get; set; }

        public bool HasStoraged { get; set; }

        public string? StoragePath { get; set; }

        public string CoverName
        {
            get => coverName ?? $"{Code}.jpg";
            set => coverName = value;
        }

        public string VideoName
        {
            get => videoName ?? $"{Code}.mp4";
            set => videoName = value;
        }

        public uint? FileSize
        {
            get
            {
                if (!HasStoraged) return null;
                if (fileSize is null)
                {
                    var file = new FileInfo(Path.Combine(StoragePath));
                    fileSize = (uint)file.Length;
                }
                return fileSize;
            }
        }

        private string? coverName;
        private string? videoName;
        private uint? fileSize;
    }
}
