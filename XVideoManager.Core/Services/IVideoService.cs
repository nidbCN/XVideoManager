using System;
using System.Collections.Generic;
using XVideoManager.Core.Entities;

namespace XVideoManager.Core.Services
{
    public interface IVideoService
    {
        #region 获取视频

        /// <summary>
        /// 获取视频列表
        /// </summary>
        /// <returns></returns>
        public IList<VideoEntity> GetVideos();

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
        public IList<VideoEntity> GetVideosByStar(string starName);

        /// <summary>
        /// 通过厂牌获取视频
        /// </summary>
        /// <param name="brandName">厂牌名</param>
        /// <returns>视频实体列表</returns>
        public IList<VideoEntity> GetVideosByBrand(string brandName);

        /// <summary>
        /// 通过标签获取视频
        /// </summary>
        /// <param name="tags">标签列表</param>
        /// <returns>视频实体列表</returns>
        public IList<VideoEntity> GetVideosByTags(params string[] tags);

        public IList<VideoEntity> GetVideos(Func<VideoEntity, bool> match);
        #endregion

        #region 添加视频
        /// <summary>
        /// 添加视频
        /// </summary>
        /// <param name="videoEntity">视频实体</param>
        public void AddVideo(VideoEntity videoEntity);

        #endregion

        #region 修改视频

        /// <summary>
        /// 设置视频为已存储
        /// </summary>
        /// <param name="video">视频实体</param>
        /// <param name="path">存储路径</param>
        /// <param name="fragments">视频片段</param>
        /// <param name="videoName">视频名称</param>
        /// <param name="coverName">封面名称</param>
        public void StorageVideo(
            VideoEntity video,
            string path,
            IList<string>? fragments,
            string? videoName = null,
            string? coverName = null);

        public void UpdateVideo(VideoEntity video, VideoEntity newVideo);

        #endregion

        #region 删除视频

        /// <summary>
        /// 删除所有视频
        /// </summary>
        public bool DeleteVideos();

        /// <summary>
        /// 删除指定视频
        /// </summary>
        /// <param name="video">视频实体</param>
        public bool DeleteVideo(VideoEntity video);

        /// <summary>
        /// 通过番号删除视频
        /// </summary>
        /// <param name="code"></param>
        public bool DeleteVideoByCode(string code);

        /// <summary>
        /// 通过女优名删除视频
        /// </summary>
        /// <param name="starName"></param>
        public bool DeleteVideosByStar(string starName);

        /// <summary>
        /// 通过厂牌删除视频
        /// </summary>
        /// <param name="brandName"></param>
        public bool DeleteVideosByBrand(string brandName);

        /// <summary>
        /// 通过标签删除视频
        /// </summary>
        /// <param name="tags"></param>
        public bool DeleteVideosByTags(params string[] tags);

        /// <summary>
        /// 通过指定条件删除视频
        /// </summary>
        /// <param name="match"></param>
        public bool DeleteVideos(Func<VideoEntity, bool> match);
        #endregion
    }
}
