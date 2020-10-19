﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseRoomConcentrationSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseRoomConcentrationSyncModel : AlipayObject
    {
        /// <summary>
        /// 阿里短号
        /// </summary>
        [JsonPropertyName("ali_short_num")]
        public string AliShortNum { get; set; }

        /// <summary>
        /// 总计房间数量
        /// </summary>
        [JsonPropertyName("all_room_num")]
        public long AllRoomNum { get; set; }

        /// <summary>
        /// 户型-房  数值范围：1-26
        /// </summary>
        [JsonPropertyName("bedroom_count")]
        public long BedroomCount { get; set; }

        /// <summary>
        /// 可租房间数量，为0时该房型不在前端展示。此字段不为空时，rent_status字段失效
        /// </summary>
        [JsonPropertyName("can_rent_num")]
        public long CanRentNum { get; set; }

        /// <summary>
        /// 可入住时间YYYY-MM-DD。大于今日，且小于等于185天
        /// </summary>
        [JsonPropertyName("checkin_time")]
        public string CheckinTime { get; set; }

        /// <summary>
        /// 小区同步请求号
        /// </summary>
        [JsonPropertyName("comm_req_id")]
        public string CommReqId { get; set; }

        /// <summary>
        /// 佣金
        /// </summary>
        [JsonPropertyName("commission")]
        public string Commission { get; set; }

        /// <summary>
        /// 佣金类型（p：百分比，m：金额）
        /// </summary>
        [JsonPropertyName("commission_type")]
        public string CommissionType { get; set; }

        /// <summary>
        /// 小区Code和小区请求号必输入其一  小区Code，详见文档  http://ecopublic.oss-cn-hangzhou.aliyuncs.com/eco/tpmogo/CommunityInfos/CommunityInfos.xls
        /// </summary>
        [JsonPropertyName("community_code")]
        public string CommunityCode { get; set; }

        /// <summary>
        /// 费用说明
        /// </summary>
        [JsonPropertyName("fee_remark")]
        public string FeeRemark { get; set; }

        /// <summary>
        /// 所在楼层
        /// </summary>
        [JsonPropertyName("floor_count")]
        public long FloorCount { get; set; }

        /// <summary>
        /// 押金   数值范围：0-￥420000.00
        /// </summary>
        [JsonPropertyName("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 免押金开始时间 YYYY-MM-dd
        /// </summary>
        [JsonPropertyName("free_begin_date")]
        public string FreeBeginDate { get; set; }

        /// <summary>
        /// 免押金结束时间 YYYY-MM-dd
        /// </summary>
        [JsonPropertyName("free_end_date")]
        public string FreeEndDate { get; set; }

        /// <summary>
        /// 通过"文件上传"接口返回的房源图片url路径。房间照片可录入0~10张,目前仅支持jpg、png、jpeg格式
        /// </summary>
        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 房源描述  字符串，最大字符长度400
        /// </summary>
        [JsonPropertyName("intro")]
        public string Intro { get; set; }

        /// <summary>
        /// 集中式最高价格，支持小数点后面2位。  新增时必输字段，修改时如果不转值则以上次接口调用值为准。
        /// </summary>
        [JsonPropertyName("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 集中式房源最大押金
        /// </summary>
        [JsonPropertyName("max_deposit_amount")]
        public string MaxDepositAmount { get; set; }

        /// <summary>
        /// 可签约至YYYY-MM-DD
        /// </summary>
        [JsonPropertyName("max_lease_time")]
        public string MaxLeaseTime { get; set; }

        /// <summary>
        /// 多少天起可租
        /// </summary>
        [JsonPropertyName("min_rent_days")]
        public long MinRentDays { get; set; }

        /// <summary>
        /// 公寓别名  是否必须:（新增）是/（修改）否
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 其它费用
        /// </summary>
        [JsonPropertyName("other_amount")]
        public List<EcoRenthouseOtherAmount> OtherAmount { get; set; }

        /// <summary>
        /// 管家姓名
        /// </summary>
        [JsonPropertyName("owners_name")]
        public string OwnersName { get; set; }

        /// <summary>
        /// 管家电话  手机号码，必须为400开头
        /// </summary>
        [JsonPropertyName("owners_tel")]
        public string OwnersTel { get; set; }

        /// <summary>
        /// 户型-厅  数值范围：0-10
        /// </summary>
        [JsonPropertyName("parlor_count")]
        public long ParlorCount { get; set; }

        /// <summary>
        /// 付款方式（1：付一，2：付二）
        /// </summary>
        [JsonPropertyName("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 付款方式列表，包括上述单独传递的付款方式。如果2种都传递，默认覆盖单独传递的付款方式。
        /// </summary>
        [JsonPropertyName("pay_type_list")]
        public List<EcoCenRenthousepayTypeList> PayTypeList { get; set; }

        /// <summary>
        /// 出租状态   数值范围：1未租、2已租
        /// </summary>
        [JsonPropertyName("rent_status")]
        public long RentStatus { get; set; }

        /// <summary>
        /// 出租类型 1：整租，2：合租
        /// </summary>
        [JsonPropertyName("rent_type")]
        public long RentType { get; set; }

        /// <summary>
        /// 租金   数值范围：￥100.00 - ￥35000.00 ，支持小数点后面2位
        /// </summary>
        [JsonPropertyName("room_amount")]
        public string RoomAmount { get; set; }

        /// <summary>
        /// 房间面积  数值范围：5.00㎡-300.00㎡，支持小数点后面2位
        /// </summary>
        [JsonPropertyName("room_area")]
        public string RoomArea { get; set; }

        /// <summary>
        /// KA内部存储的房源编号
        /// </summary>
        [JsonPropertyName("room_code")]
        public string RoomCode { get; set; }

        /// <summary>
        /// 物品配置(房间)  2:空调;3:热水器;4:洗衣机;5:冰箱;6:电视;7:微波炉;8:燃气灶;9:抽油烟机;10:电磁炉;11:床;11:WIFI;12:书桌;13:衣柜;14:沙发;15:阳台;
        /// </summary>
        [JsonPropertyName("room_configs")]
        public List<string> RoomConfigs { get; set; }

        /// <summary>
        /// 集中式房间列表
        /// </summary>
        [JsonPropertyName("room_info_list")]
        public List<EcoRenthouseRoomInfoList> RoomInfoList { get; set; }

        /// <summary>
        /// 房间最大面积
        /// </summary>
        [JsonPropertyName("room_max_area")]
        public string RoomMaxArea { get; set; }

        /// <summary>
        /// 房源初始上下架状态  上架状态租房平台会展示该房间信息，下架状态反之
        /// </summary>
        [JsonPropertyName("room_status")]
        public long RoomStatus { get; set; }

        /// <summary>
        /// 房源对应的店铺编号
        /// </summary>
        [JsonPropertyName("room_store_no")]
        public string RoomStoreNo { get; set; }

        /// <summary>
        /// 户型-卫  数值范围：0-10
        /// </summary>
        [JsonPropertyName("toilet_count")]
        public long ToiletCount { get; set; }

        /// <summary>
        /// 房屋总楼层
        /// </summary>
        [JsonPropertyName("total_floor_count")]
        public long TotalFloorCount { get; set; }
    }
}
