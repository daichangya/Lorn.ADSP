//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.ADSP.Common.DataModels
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// 广告位高宽比
    /// </summary>
    public partial class AdPositionAspectRatio
    {
        partial void InitPKDefaultValues();
        public AdPositionAspectRatio()
        {
    		InitPKDefaultValues();
            this.AdPositions = new HashSet<AdPosition>();
    
    	}
        /// <summary>
        /// AdPositionAspectRatioId
        /// </summary>
        public System.Guid AdPositionAspectRatioId { get; set; }
        /// <summary>
        /// 广告位高宽比值
        /// </summary>
        public string AdPositionAspectRatioValue { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    
         /// <summary>
        /// 广告位
        /// </summary>
        public virtual ICollection<AdPosition> AdPositions { get; set; }
         /// <summary>
        /// 所属媒体
        /// </summary>
        public virtual Media Media { get; set; }
    }
}
