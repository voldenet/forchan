using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forchan
{
    public class File
    {
        internal Model.Post Model { get; set; }
        public string Name { get { return Model.Filename; } }
        public string Extension { get { return Model.FileExtension; } }
        public int FileWidth { get { return Model.FileWidth; } }
        public int FileHeight { get { return Model.FileHeight; } }
        public int FileSize { get { return Model.FileSize; } }
    }
}
