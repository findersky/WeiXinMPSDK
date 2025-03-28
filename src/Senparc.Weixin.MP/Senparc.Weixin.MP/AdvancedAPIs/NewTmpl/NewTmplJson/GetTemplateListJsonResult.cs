﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2025 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2025 Senparc
    
    文件名：ListJsonResult.cs
    文件功能描述：“获取私有的模板列表”接口：List 结果
    
    
    创建标识：ccccccmd - 20210302

----------------------------------------------------------------*/

using System.Collections.Generic;
using Senparc.Weixin.Entities;

namespace Senparc.Weixin.MP.AdvancedAPIs.NewTmpl.NewTmplJson
{
    /// <summary>
    /// “获取私有的模板列表”接口：GetTemplateList 结果
    /// </summary>
    public class GetTemplateListJsonResult : WxJsonResult
    {
        /// <summary>
        /// 帐号下的模板列表
        /// </summary>
        public List<GetTemplateListJsonResult_data> data { get; set; }
    }

    public class GetTemplateListJsonResult_data
    {
        /// <summary>
        /// 模板id，发送小程序模板消息时所需
        /// </summary>
        public string priTmplId { get; set; }
        /// <summary>
        /// 模板标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 模板内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 模板内容示例
        /// </summary>
        public string example { get; set; }
        /// <summary>
        /// 模版类型，2 为一次性订阅，3 为长期订阅
        /// </summary>
        public int type { get; set; }
    }
}
