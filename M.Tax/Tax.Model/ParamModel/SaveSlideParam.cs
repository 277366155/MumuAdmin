﻿using System;
using System.ComponentModel.DataAnnotations;
using Tax.Model.Enum;

namespace Tax.Model.ParamModel
{
    public class SaveSlideParam : SaveStaticFilesParamBase
    {
        /// <summary>
        /// ID
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 上传文件的标题
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength(32, ErrorMessage = "名称长度不能超过32个字")]
        public override string Title { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [Required(ErrorMessage = "显示序号不能为空")]
        [Range(maximum: 999, minimum: -999, ErrorMessage = "排列序号范围为-999~999")]
        public override int SortID { get; set; }

        /// <summary>
        /// 保存路径
        /// </summary>
        [Required(ErrorMessage = "请选择图片并上传")]
        public override string SavePath { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        public override FileType Type => FileType.Slide;

        public override DateTime? CreateTime { get; set; }
        public override string Description { get; set; }
    }
}
