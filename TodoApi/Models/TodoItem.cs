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
        /// ƥ����
        /// </summary>
        [Key]
        public Guid Gid { get; set; }
        /// <summary>
        /// �ϴ��ļ���
        /// </summary>
        public string UploadFileName { get; set; }
        /// <summary>
        /// �ϴ��ļ�·��
        /// </summary>
        public string UploadFilePath { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// ״̬ 0��ƥ����  1��ƥ�����δ���� 2��ƥ�����������
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// �����ļ���
        /// </summary>
        public string DownloadFileName { get; set; }
        /// <summary>
        /// �����ļ�·��
        /// </summary>
        public string DownloadFilePath { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? DownloadTime { get; set; }
        /// <summary>
        /// ���ش���
        /// </summary>
        public int DownLoadCount { get; set; }



    }
}