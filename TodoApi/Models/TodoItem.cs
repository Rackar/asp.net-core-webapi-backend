using System;
using System.ComponentModel.DataAnnotations;
namespace TodoApi.Models
{
    public class TodoItem
    {
        //public long id {get;set;}
        //public string name {get;set;}
        //public bool iscomplete{get;set;}
        /// <summary>
        /// 匹配编号
        /// </summary>
        [Key]
        public Guid Gid { get; set; }
        /// <summary>
        /// 上传文件名
        /// </summary>
        public string UploadFileName { get; set; }
        /// <summary>
        /// 上传文件路径
        /// </summary>
        public string UploadFilePath { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 状态 0：匹配中  1：匹配完成未下载 2：匹配完成已下载
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 下载文件名
        /// </summary>
        public string DownloadFileName { get; set; }
        /// <summary>
        /// 下载文件路径
        /// </summary>
        public string DownloadFilePath { get; set; }
        /// <summary>
        /// 下载时间
        /// </summary>
        public DateTime? DownloadTime { get; set; }
        /// <summary>
        /// 下载次数
        /// </summary>
        public int DownLoadCount { get; set; }



    }
}