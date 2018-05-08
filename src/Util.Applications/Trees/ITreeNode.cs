﻿namespace Util.Applications.Trees {
    /// <summary>
    /// 树节点
    /// </summary>
    public interface ITreeNode {
        /// <summary>
        /// 标识
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// 父标识
        /// </summary>
        string ParentId { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        string Path { get; set; }
        /// <summary>
        /// 级数
        /// </summary>
        int? Level { get; set; }
        /// <summary>
        /// 是否展开
        /// </summary>
        bool? Expanded { get; set; }
    }
}
