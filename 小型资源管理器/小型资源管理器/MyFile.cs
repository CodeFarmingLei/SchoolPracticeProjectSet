using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小型资源管理器
{
    class MyFile
    {
        public string FileName { get; set; }    //文件名称
        public long FileLength { get; set; }  //文件大小
        public string FileType { get; set; }    //文件扩展名
        public string FilePath { get; set; }    //文件路径
    }
}
