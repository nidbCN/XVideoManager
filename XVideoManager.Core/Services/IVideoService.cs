using System;
using System.Collections.Generic;
using System.Text;
using XVideoManager.Core.Entities;

namespace XVideoManager.Core.Services
{
    public interface IVideoService
    { 
        public IList<VideoEntity> GetVideoList();

        public void AddVideo(VideoEntity videoEntity);

        public void StorageVideo(
            VideoEntity video,
            string path,
            IList<string>? fragments,
            string? videoName = null,
            string? coverName = null);

        /// <summary>
        /// 通过番号获取视频
        /// </summary>
        /// <param name="code">番号</param>
        /// <returns>视频实体</returns>
        public VideoEntity GetVideoByCode(string code);

        /// <summary>
        /// 通过女优名获取视频
        /// </summary>
        /// <param name="starName">女优名</param>
        /// <returns>视频实体列表</returns>
        public IList<VideoEntity> GetVideoByStar(string starName);

        /// <summary>
        /// 通过厂牌获取视频
        /// </summary>
        /// <param name="brandName">厂牌名</param>
        /// <returns>视频实体列表</returns>
        public IList<VideoEntity> GetVideoByBrand(string brandName);
        
        /// <summary>
        /// 通过标签获取视频
        /// </summary>
        /// <param name="tags">标签列表</param>
        /// <returns>视频实体列表</returns>
        public IList<VideoEntity> GetVideoByTags(params string[] tags);
    }
}
