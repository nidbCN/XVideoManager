using System;
using System.IO;
using System.Collections.Generic;
using XVideoManager.Core.Utils;

namespace XVideoManager.Core.Entities
{
    public class VideoEntity
    {
        #region 构造函数

        public VideoEntity(string code, string title, string banner, Uri link)
        {
            Code = code
                ?? throw new ArgumentNullException(nameof(code));
            Title = title
                ?? throw new ArgumentNullException(nameof(title));
            BrandName = banner
                ?? throw new ArgumentNullException(nameof(banner));
            Link = link
                ?? throw new ArgumentNullException(nameof(link));
        }

        public VideoEntity(
            string code, string title,
            string banner, Uri link,
            bool hasStoraged, string storgaePath)
        {
            Code = code
                ?? throw new ArgumentNullException(nameof(code));
            Title = title
                ?? throw new ArgumentNullException(nameof(title));
            BrandName = banner
                ?? throw new ArgumentNullException(nameof(banner));
            Link = link
                ?? throw new ArgumentNullException(nameof(link));

            if (hasStoraged)
            {
                StoragePath = storgaePath
                    ?? throw new ArgumentNullException(nameof(storgaePath));
                HasStoraged = hasStoraged;
                fileSize = FileUtil.GetSize(StoragePath);
            }
        }

        #endregion

        #region 属性

        /// <summary>
        /// 番号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 片商
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 出演女优
        /// </summary>
        public IList<string>? Stars { get; set; }

        /// <summary>
        /// 是否存储
        /// </summary>
        public bool HasStoraged { get; set; }

        /// <summary>
        /// 存储路径
        /// </summary>
        public string? StoragePath { get; set; }

        /// <summary>
        /// 封面文件名
        /// </summary>
        public string? CoverName
        {
            get => HasStoraged ? coverName ?? $"{Code}.jpg" : null;
            set => coverName = value;
        }

        /// <summary>
        /// 源视频文件名
        /// </summary>
        public string? VideoName
        {
            get => HasStoraged ? videoName ?? $"{Code}.mp4" : null;
            set => videoName = value;
        }

        /// <summary>
        /// 文件大小
        /// </summary>
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

        /// <summary>
        /// 视频片段
        /// </summary>
        public IList<string>? Fragments { get; set; }

        /// <summary>
        /// 网页链接
        /// </summary>
        public Uri Link { get; set; }

        #endregion

        #region 字段
        private string? coverName;
        private string? videoName;
        private uint? fileSize;
        #endregion
    }
}
