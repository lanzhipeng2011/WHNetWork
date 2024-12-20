//This code create by CodeEngine, do NOT modify

using System;
public enum MessageID :ushort {
    PACKET_NONE                             = 0,

    //系统相关: id = 0, name = sys
    PACKET_CG_CONNECTED_HEARTBEAT           = 1, // 1:cg_connected_heartbeat
    PACKET_GC_CONNECTED_HEARTBEAT           = 2, // 2:gc_connected_heartbeat
    PACKET_GC_NOTICE                        = 3, // 3:gc_notice
    PACKET_GC_UPDATENOTICEDATA              = 4, // 4:gc_updatenoticedata
    PACKET_GC_SERVER_CONFIG                 = 5, // 5:
    PACKET_GC_SERVERFLAGS                   = 6, // 6:
    PACKET_GC_ACTIVITYNOTICE                = 7, // 7:

    //账户信息: id = 1, name = acc
    PACKET_CG_LOGIN                         = 257, // 1:用户登录
    PACKET_GC_LOGIN_RET                     = 258, // 2:用户登录返回值
    PACKET_CG_SELECTROLE                    = 259, // 3:选择角色
    PACKET_GC_SELECTROLE_RET                = 260, // 4:选择角色结果
    PACKET_CG_CREATEROLE                    = 261, // 5:创建角色
    PACKET_GC_CREATEROLE_RET                = 262, // 6:创建角色结果
    PACKET_CG_REQ_RANDOMNAME                = 263, // 7:客户端请求随机名字
    PACKET_GC_RET_RANDOMNAME                = 264, // 8:返回随机名字
    PACKET_CG_REQ_CHANGENAME                = 265, // 9:修改名称
    PACKET_GC_RET_CHANGENAME                = 266, // 10:修改名称应答
    PACKET_GC_CHANGENAME                    = 267, // 11:修改名称应答
    PACKET_CG_PAY_ORDER                     = 268, // 12:玩家请求创建订单
    PACKET_GC_PAY_ORDER                     = 269, // 13:玩家请求创建订单结果
    PACKET_CG_ASK_QUIT_GAME                 = 296, // 40:退出游戏
    PACKET_GC_RET_QUIT_GAME                 = 297, // 41:退出游戏应答

    //地图场景: id = 2, name = map
    PACKET_GC_ENTER_SCENE                   = 513, // 1:通知玩家进入场景
    PACKET_CG_ENTER_SCENE_OK                = 514, // 2:客户端通知进入场景成功
    PACKET_CG_REQ_CHANGE_SCENE              = 515, // 3:客户端请求切换场景
    PACKET_GC_CREATE_PLAYER                 = 516, // 4:通知玩家创建角色
    PACKET_GC_DELETE_OBJ                    = 517, // 5:通知玩家删除对象(其他玩家，怪物，npc等)
    PACKET_CG_SYNC_POS                      = 518, // 6:客户端强制同步位置
    PACKET_GC_SYNC_POS                      = 519, // 7:服务端通知同步位置
    PACKET_CG_MOVE                          = 520, // 8:玩家请求移动
    PACKET_GC_MOVE                          = 521, // 9:服务器通知移动信息
    PACKET_GC_STOP                          = 522, // 10:服务器通知对象停止移动
    PACKET_CG_REQ_NEAR_LIST                 = 523, // 11:玩家查询最近的队伍或者其他玩家列表
    PACKET_GC_NEAR_PLAYERLIST               = 524, // 12:
    PACKET_GC_NEAR_TEAMLIST                 = 525, // 13:
    PACKET_GC_CREATE_NPC                    = 526, // 14:创建npc或者怪物
    PACKET_GC_PLAYSTORY                     = 527, // 15:通知播放剧情
    PACKET_CG_PLAYSTORY_OVER                = 528, // 16:客户端通知播放剧情结束
    PACKET_CG_ASK_RELIVE                    = 529, // 17:客户端请求重生
    PACKET_GC_RET_RELIVE                    = 530, // 18:重生结果
    PACKET_GC_DROPITEM_INFO                 = 531, // 19:物品掉落信息
    PACKET_GC_CREATE_FELLOW                 = 532, // 20:创建宠物
    PACKET_GC_CREATE_ZOMBIEUSER             = 533, // 21:创建傀儡镜像玩家
    PACKET_CG_ASK_SELOBJ_INFO               = 534, // 22:查询选择目标基本信息(玩家，怪物，npc)
    PACKET_GC_RET_SELOBJ_INFO               = 535, // 23:返回查询目标结果
    PACKET_GC_DAMAGEBOARD_INFO              = 536, // 24:通知伤害信息
    PACKET_CG_OPEN_COPYSCENE                = 537, // 25:创建副本
    PACKET_GC_COPYSCENE_INVITE              = 538, // 26:发送副本邀请
    PACKET_CG_COPYSCENE_INVITE_RET          = 539, // 27:副本邀请处理结果
    PACKET_CG_ASK_TEAMPLATFORMINFO          = 540, // 28:
    PACKET_GC_RET_TEAMPLATFORMINFO          = 541, // 29:
    PACKET_GC_TELEMOVE                      = 543, // 31:转换方向
    PACKET_GC_PLAY_EFFECT                   = 545, // 33:释放特效
    PACKET_GC_OP_TELEPORT                   = 546, // 34:朝向移动
    PACKET_GC_OP_QINGGONGPOINT              = 547, // 35:
    PACKET_GC_SCENE_TIMESCALE               = 548, // 36:
    PACKET_CG_LEAVE_COPYSCENE               = 549, // 37:离开副本
    PACKET_GC_UPDATE_ANIMATION_STATE        = 550, // 38:
    PACKET_CG_CHANGE_MAJORCITY              = 551, // 39:改变主城
    PACKET_GC_REMOVEEFFECT                  = 552, // 40:
    PACKET_GC_SYNC_REACHEDSCENE             = 554, // 42:同步角色到达的场景
    PACKET_GC_FORCE_SETPOS                  = 555, // 43:强制设置位置
    PACKET_GC_DEBUG_MY_POS                  = 556, // 44:调试位置
    PACKET_CG_SCENE_CHANGEINST              = 557, // 45:切换场景分线
    PACKET_CG_ASK_TRAIL                     = 562, // 50:
    PACKET_GC_RET_TRAIL                     = 563, // 51:
    PACKET_CG_FACEDIR_PLAYER                = 564, // 52:玩家改变朝向
    PACKET_GC_SYNC_PLAYERFACEDIR            = 565, // 53:同步玩家朝向
    PACKET_GC_CREATE_SNARE                  = 566, // 54:创建陷阱

    //玩家信息: id = 3, name = player
    PACKET_CG_COMBATVALUE_ASK               = 769, // 1:请求玩家战斗力
    PACKET_GC_COMBATVALUE_RET               = 770, // 2:请求玩家战斗力结果
    PACKET_CG_ASK_PKINFO                    = 771, // 3:查询pk模式
    PACKET_GC_RET_PKINFO                    = 772, // 4:pk模式结果
    PACKET_CG_CHANGE_PKMODLE                = 773, // 5:改变pk模式
    PACKET_GC_RET_CHANGE_PKMODLE            = 774, // 6:改变pk模式结果
    PACKET_GC_CHANGE_PKLIST                 = 775, // 7:通知前端pk模式列表
    PACKET_GC_BROADCAST_ATTR                = 777, // 9:广播玩家属性
    PACKET_GC_SYN_ATTR                      = 778, // 10:同步玩家属性
    PACKET_CG_USER_BEHAVIOR                 = 779, // 11:
    PACKET_CG_ASK_ROLE_DATA                 = 780, // 12:查询角色数据
    PACKET_GC_RET_ROLE_DATA                 = 781, // 13:角色数据结果
    PACKET_CG_ASK_PICKUP_ITEM               = 782, // 14:玩家拾取一个箱子物品
    PACKET_GC_RET_PICKUP_ITEM               = 783, // 15:玩家拾取一个箱子物品结果
    PACKET_CG_ASK_OTHERROLE_DATA            = 784, // 16:玩家查询其他玩家的数据
    PACKET_GC_RET_OTHERROLE_DATA            = 785, // 17:玩家查询其他玩家数据结果
    PACKET_GC_UPDATE_NEEDIMPACTINFO         = 786, // 18:玩家身上buff信息
    PACKET_CG_REQ_POWERUP                   = 787, // 19:玩家变强数据列表
    PACKET_GC_RES_POWERUP                   = 788, // 20:玩家变强结果
    PACKET_GC_POWERUP_LIST                  = 789, // 21:玩家可以变强的项目列表
    PACKET_GC_SYNC_PLAYER_STATE             = 790, // 22:同步玩家状态

    //任务信息: id = 4, name = task
    PACKET_GC_MISSION_SYNC_MISSIONLIST      = 1025, // 1:同步玩家的任务数据
    PACKET_CG_ACCEPTMISSION                 = 1026, // 2:玩家请求接受任务
    PACKET_GC_ACCEPTMISSION_RET             = 1027, // 3:接受任务结果
    PACKET_CG_COMPLETEMISSION               = 1028, // 4:玩家完成提交任务
    PACKET_GC_COMPLETEMISSION_RET           = 1029, // 5:玩家提交任务结果
    PACKET_CG_ABANDONMISSION                = 1030, // 6:玩家取消任务
    PACKET_GC_ABANDONMISSION_RET            = 1031, // 7:玩家取消任务结果
    PACKET_GC_MISSION_STATE                 = 1032, // 8:玩家任务状态
    PACKET_GC_MISSION_PARAM                 = 1033, // 9:玩家任务计数
    PACKET_GC_MISSION_IGNOREMISSIONPREFLAG  = 1034, // 10:
    PACKET_CG_DAILYMISSION_UPDATE           = 1035, // 11:玩家每日任务更新
    PACKET_GC_DAILYMISSION_UPDATE_RET       = 1036, // 12:玩家每日任务更新结果
    PACKET_CG_ASK_GUILDBUSINESS_ACCEPT      = 1037, // 13:玩家接受家族任务

    //技能相关: id = 5, name = skill
    PACKET_CG_SKILL_USE                     = 1281, // 1:玩家使用技能
    PACKET_GC_RET_USE_SKILL                 = 1282, // 2:玩家使用技能结果
    PACKET_GC_CDTIME_UPDATE                 = 1283, // 3:玩家技能cd
    PACKET_GC_SKILL_FINISH                  = 1284, // 4:玩家技能强制结束
    PACKET_GC_SKILL_STUDY                   = 1285, // 5:玩家技能升级学习
    PACKET_GC_SYN_SKILLINFO                 = 1286, // 6:同步玩家技能信息
    PACKET_GC_UPDATE_SCENE_INSTACTIVATION   = 1287, // 7:
    PACKET_GC_UPDATE_HITPONIT               = 1288, // 8:
    PACKET_CG_ASK_LEVELUPSKILL              = 1289, // 9:升级技能
    PACKET_GC_ATTACKFLY                     = 1290, // 10:
    PACKET_GC_SHOW_SKILLNAME                = 1292, // 12:通知显示技能名称
    PACKET_CG_MASTER_ACTIVE_SKILL           = 1293, // 13:激活宗派技能
    PACKET_GC_MASTER_LEARN_SKILL            = 1294, // 14:学习宗派技能
    PACKET_CG_MASTER_FORGET_SKILL           = 1295, // 15:遗忘宗派技能
    PACKET_GC_MASTER_FORGET_SKILL           = 1296, // 16:遗忘技能结果
    PACKET_CG_MASTER_LEARN_SKILL            = 1297, // 17:宗派技能学习
    PACKET_GC_MASTER_ACTIVE_SKILL           = 1298, // 18:宗派技能激活
    PACKET_GC_SYNC_MASTER_SKILL_NAME        = 1299, // 19:同步宗派技能名称
    PACKET_GC_PLAYSHANDIANLIANEFFECT        = 1300, // 20:播放闪电技能效果

    //聊天: id = 6, name = chat
    PACKET_CG_CHAT                          = 1537, // 1:发送聊天
    PACKET_GC_CHAT                          = 1538, // 2:
    PACKET_CG_GMCOMMAND                     = 1539, // 3:gm命令
    PACKET_CG_ASK_LOUDSPEAKER_POOL          = 1540, // 4:
    PACKET_GC_ASK_LOUDSPEAKER_CONTENT       = 1541, // 5:

    //活动: id = 7, name = active
    PACKET_CG_ASK_NEWSERVERAWARD            = 1793, // 1:
    PACKET_GC_NEWSERVERAWARD_DATA           = 1794, // 2:
    PACKET_CG_ASK_DAYAWARD                  = 1795, // 3:
    PACKET_GC_DAYAWARD_DATA                 = 1796, // 4:
    PACKET_CG_ASK_ONLINEAWARD               = 1797, // 5:
    PACKET_GC_ONLINEAWARD_DATA              = 1798, // 6:
    PACKET_CG_ASK_ACTIVENESSAWARD           = 1799, // 7:
    PACKET_GC_ASK_ACTIVENESSAWARD_RET       = 1800, // 8:
    PACKET_GC_SYNC_ACTIVENESSAWARD          = 1801, // 9:
    PACKET_CG_ASK_LEVELAWARD                = 1804, // 12:
    PACKET_GC_LEVELAWARD_DATA               = 1805, // 13:
    PACKET_GC_SYNC_ACTIVENESS               = 1806, // 14:
    PACKET_CG_ASK_DAILYAWARD                = 1807, // 15:
    PACKET_GC_DAILYAWARD_DATA               = 1808, // 16:
    PACKET_CG_ASK_7DAYAWARD                 = 1809, // 17:首周7日奖励
    PACKET_GC_7DAYAWARD_DATA                = 1810, // 18:首周7日奖励结果

    //美人: id = 8, name = belle
    PACKET_GC_BELLE_DATA                    = 2049, // 1:
    PACKET_CG_BELLE_CLOSE                   = 2050, // 2:
    PACKET_GC_BELLE_CLOSE_RET               = 2051, // 3:
    PACKET_CG_BELLE_EVOLUTION               = 2052, // 4:
    PACKET_GC_BELLE_EVOLUTION_RET           = 2053, // 5:
    PACKET_CG_BELLE_EVOLUTIONRAPID          = 2054, // 6:
    PACKET_GC_BELLE_EVOLUTIONRAPID_RET      = 2055, // 7:
    PACKET_CG_BELLE_BATTLE                  = 2056, // 8:
    PACKET_GC_BELLE_BATTLE_RET              = 2057, // 9:
    PACKET_CG_BELLE_REST                    = 2058, // 10:
    PACKET_GC_BELLE_REST_RET                = 2059, // 11:
    PACKET_CG_BELLE_ACTIVEMATRIX            = 2060, // 12:
    PACKET_GC_BELLE_ACTIVEMATRIX_RET        = 2061, // 13:
    PACKET_GC_BELLE_ACTIVE                  = 2062, // 14:
    PACKET_CG_BELLE_CANCELMATRIX            = 2063, // 15:
    PACKET_GC_BELLE_CANCELMATRIX_RET        = 2064, // 16:

    //商店: id = 10, name = shop
    PACKET_CG_ASK_YUANBAOSHOP_OPEN          = 2561, // 1:
    PACKET_GC_RET_YUANBAOSHOP_OPEN          = 2562, // 2:
    PACKET_CG_BUY_YUANBAOGOODS              = 2563, // 3:
    PACKET_CG_BUY_FASHION                   = 2564, // 4:购买时装
    PACKET_CG_BUY_STAMINA                   = 2565, // 5:耐力购买,生活技能使用
    PACKET_CG_SYSTEMSHOP_BUY                = 2566, // 6:
    PACKET_CG_SYSTEMSHOP_BUYBACK            = 2567, // 7:
    PACKET_CG_SYSTEMSHOP_VIEW               = 2568, // 8:
    PACKET_GC_SYSTEMSHOP_MERCHANDISELIST    = 2570, // 10:
    PACKET_CG_SYSTEMSHOP_SELL               = 2571, // 11:物品出售
    PACKET_CG_MASTERSHOP_BUY                = 2572, // 12:
    PACKET_GC_MASTERSHOP_BUY                = 2573, // 13:
    PACKET_CG_BUY_GUILDGOODS                = 2574, // 14:
    PACKET_GC_BUY_GUILDGOODS                = 2575, // 15:
    PACKET_CG_ASK_BLACKMARKETITEMINFO       = 2576, // 16:
    PACKET_CG_BUY_BLACKMARKETITEM           = 2577, // 17:
    PACKET_GC_CLOSE_BLACKMARKET             = 2578, // 18:
    PACKET_GC_RET_BLACKMARKETITEMINFO       = 2579, // 19:
    PACKET_GC_SHOW_BLACKMARKET              = 2580, // 20:

    //公会: id = 11, name = guild
    PACKET_CG_GUILD_REQ_LIST                = 2817, // 1:申请家族列表信息
    PACKET_GC_GUILD_RET_LIST                = 2818, // 2:返回所有家族信息
    PACKET_CG_GUILD_REQ_INFO                = 2819, // 3:申请本家族信息
    PACKET_GC_GUILD_RET_INFO                = 2820, // 4:返回本家族信息
    PACKET_CG_GUILD_REQ_CHANGE_NOTICE       = 2821, // 5:申请修改家族公告
    PACKET_CG_GUILD_CREATE                  = 2822, // 6:申请创建家族
    PACKET_GC_GUILD_CREATE                  = 2823, // 7:家族创建申请回执
    PACKET_CG_GUILD_JOIN                    = 2824, // 8:申请加入家族
    PACKET_GC_GUILD_JOIN                    = 2825, // 9:加入家族申请回执
    PACKET_CG_GUILD_JOIN_OTHERPLAYER        = 2826, // 10:申请加入其他人所在的家族
    PACKET_CG_GUILD_INVITE                  = 2827, // 11:玩家A邀请玩家B入家族
    PACKET_GC_GUILD_INVITE_CONFIRM          = 2828, // 12:服务器转发给玩家B入家族邀请
    PACKET_CG_GUILD_INVITE_CONFIRM          = 2829, // 13:玩家B被邀请回执
    PACKET_CG_GUILD_LEAVE                   = 2830, // 14:申请离开家族
    PACKET_GC_GUILD_LEAVE                   = 2831, // 15:离开家族申请回执
    PACKET_CG_GUILD_KICK                    = 2832, // 16:申请踢出家族成员
    PACKET_CG_GUILD_JOB_CHANGE              = 2833, // 17:改变家族职位
    PACKET_CG_GUILD_APPROVE_RESERVE         = 2834, // 18:会长审批入家族请求
    PACKET_CG_GUILD_REQ_LEVELUP             = 2835, // 19:家族升级请求
    PACKET_GC_GUILD_RET_LEVELUP             = 2836, // 20:申请家族升级回执
    PACKET_GC_GUILD_NEWRESERVE              = 2837, // 21:家族有待审批成员界面提示
    PACKET_GC_GUILDACTIVITY_BOSSDATA        = 2838, // 22:家族聚宝盆刷新同步
    PACKET_CG_ASK_SETAUTOASSIGNPSTIMES      = 2839, // 23:CG_ASK_SETAUTOASSIGNPSTIMES
    PACKET_CG_ASSIGN_GUILDBUSINESS_TIME     = 2840, // 24:CG_ASSIGN_GUILDBUSINESS_TIME
    PACKET_CG_ASK_GUILDBUSINESSINFO         = 2841, // 25:CG_ASK_GUILDBUSINESSINFO
    PACKET_GC_RET_GUILDBUSINESSINFO         = 2842, // 26:GC_RET_GUILDBUSINESSINFO
    PACKET_CG_ASK_GUILD_MAKE                = 2843, // 27:CG_ASK_GUILD_MAKE
    PACKET_CG_ASK_GUILDMISSIONINFO          = 2844, // 28:CG_ASK_GUILDMISSIONINFO
    PACKET_GC_RET_GUILDMISSIONINFO          = 2845, // 29:GC_RET_GUILDMISSIONINFO
    PACKET_CG_ASSIGN_GUILDMISSION           = 2846, // 30:CG_ASSIGN_GUILDMISSION
    PACKET_CG_PARTAKE_GUILDMISSION          = 2847, // 31:CG_PARTAKE_GUILDMISSION

    //物品|装备: id = 12, name = goods
    PACKET_GC_UPDATEITEM                    = 3073, // 1:更新物品信息
    PACKET_CG_USE_ITEM                      = 3074, // 2:使用道具
    PACKET_GC_USE_ITEM_RET                  = 3075, // 3:返回使用道具结果
    PACKET_CG_EQUIP_ITEM                    = 3076, // 4:请求装备道具
    PACKET_CG_UNEQUIP_ITEM                  = 3077, // 5:请求卸载道具
    PACKET_CG_THROW_ITEM                    = 3078, // 6:请求丢弃物品
    PACKET_CG_PUT_ITEM_STORAGEPACK          = 3079, // 7:请求放入物品至仓库
    PACKET_GC_PUT_ITEM_STORAGEPACK_RET      = 3080, // 8:返回放入物品至仓库结果
    PACKET_CG_TAKE_ITEM_STORAGEPACK         = 3081, // 9:请求从仓库取出物品
    PACKET_GC_TAKE_ITEM_STORAGEPACK_RET     = 3082, // 10:返回从仓库取出物品结果
    PACKET_CG_STORAGEPACK_UNLOCK            = 3083, // 11:请求解锁仓库
    PACKET_CG_BACKPACK_UNLOCK               = 3084, // 12:请求解锁背包
    PACKET_GC_BACKPACK_RESIZE               = 3085, // 13:返回解锁后容器数据(背包、仓库共用)
    PACKET_CG_EQUIP_ENCHANCE                = 3086, // 14:请求强化装备
    PACKET_GC_EQUIP_ENCHANCE_RET            = 3087, // 15:返回装备强化结果
    PACKET_CG_EQUIP_STAR                    = 3088, // 16:请求装备打星
    PACKET_GC_EQUIP_STAR_RET                = 3089, // 17:返回装备打星结果
    PACKET_CG_PUT_GEM                       = 3090, // 18:请求镶嵌宝石
    PACKET_GC_PUT_GEM_RET                   = 3091, // 19:返回镶嵌宝石结果
    PACKET_CG_TAKE_GEM                      = 3092, // 20:请求摘除宝石
    PACKET_GC_TAKE_GEM_RET                  = 3093, // 21:返回摘除宝石结果
    PACKET_GC_UPDATE_GEM_INFO               = 3094, // 22:发送宝石信息
    PACKET_GC_SHOW_USEITEMREMIND            = 3095, // 23:发送使用物品提醒
    PACKET_GC_SHOW_ITEMREMIND               = 3096, // 24:发送物品提醒
    PACKET_GC_SHOW_EQUIPREMIND              = 3097, // 25:发送装备提醒
    PACKET_CG_ASK_UPDATE_STORAGEPACK        = 3098, // 26:请求仓库数据
    PACKET_GC_UPDATE_STORAGEPACK            = 3099, // 27:返回仓库数据
    PACKET_GC_ASK_UPDATE_STORAGEPACK_RET    = 3100, // 28:返回请求仓库结果
    PACKET_GC_RET_PUT_GEM                   = 3101, // 29:xxxxx
    PACKET_CG_QIANKUNDAI_COMBINE            = 3102, // 30:乾坤袋
    PACKET_GC_QIANKUNDAI_PRODUCT            = 3103, // 31:乾坤袋
    PACKET_CG_USE_LIVINGSKILL               = 3104, // 32:打造/制药
    PACKET_CG_WEAR_FASHION                  = 3105, // 33:穿时装
    PACKET_CG_ASK_TIDY                      = 3106, // 34:整理背包
    PACKET_GC_UPDATE_STAMINA_TIME           = 3107, // 35:同步玩家的体力恢复时间
    PACKET_GC_ADDITIONINFO_UPDATE           = 3108, // 36:双倍经验持续时间

    //邮件: id = 13, name = mail
    PACKET_GC_MAIL_UPDATE                   = 3329, // 1:
    PACKET_GC_MAIL_DELETE                   = 3330, // 2:删除邮件
    PACKET_CG_MAIL_SEND                     = 3331, // 3:发送邮件
    PACKET_CG_MAIL_OPERATION                = 3332, // 4:邮件内容提取
    PACKET_CG_SEND_GUILDMAIL                = 3333, // 5:发送家族邮件

    //坐骑: id = 14, name = mounts
    PACKET_GC_MOUNTCOLLECTED_FLAG           = 3585, // 1:玩家坐骑标记
    PACKET_GC_MOUNT_DATA                    = 3586, // 2:玩家当前坐骑
    PACKET_CG_MOUNT_MARK                    = 3587, // 3:设置自动骑乘
    PACKET_GC_MOUNT_MARK_RET                = 3588, // 4:自动骑乘结果
    PACKET_CG_MOUNT_MOUNT                   = 3589, // 5:玩家上坐骑
    PACKET_CG_MOUNT_UNMOUNT                 = 3590, // 6:玩家下坐骑

    //社交: id = 15, name = relation
    PACKET_CG_ADDFRIEND                     = 3841, // 1:
    PACKET_GC_ADDFRIEND                     = 3842, // 2:
    PACKET_CG_DELFRIEND                     = 3843, // 3:
    PACKET_CG_REQ_FRIEND_USERINFO           = 3844, // 4:
    PACKET_GC_RET_FRIEND_USERINFO           = 3845, // 5:
    PACKET_GC_DELFRIEND                     = 3846, // 6:
    PACKET_GC_NOTICE_ADDED_FRIEND           = 3847, // 7:
    PACKET_GC_SYC_FRIEND_STATE              = 3848, // 8:
    PACKET_GC_SYC_FRIEND_INFO               = 3849, // 9:
    PACKET_GC_SYC_FULL_FRIEND_LIST          = 3850, // 10:
    PACKET_CG_ADDBLACKLIST                  = 3852, // 12:
    PACKET_GC_ADDBLACKLIST                  = 3853, // 13:
    PACKET_GC_SYC_FULL_BLACK_LIST           = 3854, // 14:
    PACKET_CG_DELBLACKLIST                  = 3855, // 15:
    PACKET_GC_DELBLACKLIST                  = 3856, // 16:
    PACKET_CG_FINDPLAYER                    = 3857, // 17:
    PACKET_GC_FINDPLAYER                    = 3858, // 18:
    PACKET_GC_SYNSELTRAGET_ATTR             = 3859, // 19:
    PACKET_CG_SNS_INVITE_CODE               = 3860, // 20:
    PACKET_GC_SNS_INVITE_CODE_RESPONSE      = 3861, // 21:
    PACKET_GC_SNS_ACTIVE_SHOW               = 3862, // 22:
    PACKET_CG_SNS_SHARE                     = 3863, // 23:
    PACKET_GC_SYC_FULL_HATE_LIST            = 3864, // 24:
    PACKET_CG_DELHATELIST                   = 3865, // 25:
    PACKET_GC_DELHATELIST                   = 3866, // 26:
    PACKET_GC_ADDHATELIST                   = 3867, // 27:

    //队伍: id = 16, name = team
    PACKET_CG_REQ_TEAM_INVITE               = 4097, // 1:创建队伍
    PACKET_CG_REQ_TEAM_JOIN                 = 4098, // 2:申请加入队伍
    PACKET_CG_REQ_TEAM_LEAVE                = 4099, // 3:申请离开队伍
    PACKET_CG_REQ_TEAM_KICK_MEMBER          = 4100, // 4:踢出队伍成员
    PACKET_CG_REQ_TEAM_CHANGE_LEADER        = 4101, // 5:改变队伍队长
    PACKET_GC_TEAM_LEAVE                    = 4102, // 6:离开队伍结果
    PACKET_GC_TEAM_SYNC_TEAMINFO            = 4103, // 7:同步队伍属性
    PACKET_GC_TEAM_SYNC_MEMBERINFO          = 4104, // 8:同步队伍成员属性
    PACKET_GC_JOIN_TEAM_INVITE              = 4105, // 9:组队邀请
    PACKET_CG_JOIN_TEAM_INVITE_RESULT       = 4106, // 10:
    PACKET_CG_JOIN_TEAM_REQUEST_RESULT      = 4107, // 11:请求加入队伍结果
    PACKET_GC_JOIN_TEAM_REQUEST             = 4108, // 12:加入队伍请求结果
    PACKET_CG_ASK_AUTOTEAM                  = 4111, // 15:一键自动组队
    PACKET_GC_RET_AUTOTEAM                  = 4112, // 16:一键自动组队结果

    //称号: id = 17, name = title
    PACKET_GC_UPDATE_ALL_TITLEINVESTITIVE   = 4353, // 1:
    PACKET_CG_ACTIVE_TITLE                  = 4354, // 2:
    PACKET_CG_DELETE_TITLE                  = 4355, // 3:
    PACKET_GC_GAIN_TITLE                    = 4356, // 4:
    PACKET_GC_DELETE_TITLE                  = 4357, // 5:
    PACKET_GC_ACTIVE_TITLE                  = 4358, // 6:
    PACKET_GC_SYNC_ACTIVETITLE              = 4359, // 7:
    PACKET_CG_ASK_LOCK_TITLE                = 4360, // 8:
    PACKET_GC_RET_LOCK_TITLE                = 4361, // 9:
    PACKET_GC_UPDATE_DEF_TITLE              = 4362, // 10:

    //世界boss: id = 18, name = boss
    PACKET_GC_WORLDBOSS_DEAD                = 4609, // 1:广播世界boss死亡消息
    PACKET_CG_WORLDBOSS_TEAMLIST_REQ        = 4610, // 2:查询世界boss队伍排名
    PACKET_GC_WORLDBOSS_TEAMLIST            = 4611, // 3:世界boss队伍排名结果
    PACKET_GC_WORLDBOSS_OPEN                = 4612, // 4:世界boss已经开启
    PACKET_CG_WORLDBOSS_CHALLENGE           = 4613, // 5:世界boss挑战
    PACKET_CG_WORLDBOSS_JOIN                = 4614, // 6:请求杀死世界boss
    PACKET_GC_WORLDBOSS_SOMECHALL_ME        = 4615, // 7:
    PACKET_CG_WORLDBOSS_CHALL_RESPONSE      = 4616, // 8:
    PACKET_GC_WORLDBOSS_CHALLEGE_RES        = 4617, // 9:

    //宠物(伙伴): id = 19, name = pet
    PACKET_GC_UPDATE_FELLOW                 = 4865, // 1:更新宠物
    PACKET_CG_CALL_FELLOW                   = 4867, // 3:宠物出战
    PACKET_GC_CALL_FELLOW_RET               = 4868, // 4:宠物出战应答
    PACKET_CG_UNCALL_FELLOW                 = 4869, // 5:宠物召回
    PACKET_GC_UNCALL_FELLOW_RET             = 4870, // 6:宠物召回应答
    PACKET_CG_LOCK_FELLOW                   = 4871, // 7:锁定宠物
    PACKET_CG_UNLOCK_FELLOW                 = 4872, // 8:解锁宠物
    PACKET_CG_RESOLVE_FELLOW                = 4873, // 9:溶解宠物(废弃的消息)
    PACKET_GC_RESOLVE_FELLOW_RET            = 4874, // 10:溶解宠物结果(废弃的消息)
    PACKET_CG_ASK_GAIN_FELLOW               = 4875, // 11:抽取宠物
    PACKET_GC_ASK_GAIN_FELLOW_RET           = 4876, // 12:抽取宠物结果
    PACKET_GC_UPDATE_GAIN_FELLOW_COUNT      = 4877, // 13:更新抽取宠物计数
    PACKET_CG_FELLOW_STAR                   = 4878, // 14:请求宠物升星
    PACKET_GC_FELLOW_STAR_RET               = 4879, // 15:请求宠物升星结果
    PACKET_CG_FELLOW_ENCHANCE               = 4880, // 16:宠物资质强化
    PACKET_GC_FELLOW_ENCHANCE_RET           = 4881, // 17:宠物资质强化结果
    PACKET_CG_FELLOW_APPLY_POINT            = 4882, // 18:保存宠物洗点结果
    PACKET_GC_FELLOW_APPLY_POINT_RET        = 4883, // 19:保存宠物洗点结果的返回
    PACKET_CG_ASK_GAIN_10_FELLOW            = 4884, // 20:宠物10连抽
    PACKET_GC_ASK_GAIN_10_FELLOW_RET        = 4885, // 21:宠物10连抽结果
    PACKET_CG_FELLOW_CHANGE_NAME            = 4886, // 22:宠物改名
    PACKET_GC_FELLOW_CHANGE_NAME_RET        = 4887, // 23:宠物改名结果
    PACKET_CG_ACTIVE_FELLOW_SKILL           = 4888, // 24:激活宠物技能
    PACKET_CG_FELLOW_RESET_POINT            = 4889, // 25:宠物洗点
    PACKET_GC_RET_FELLOW_RESET_POINT        = 4890, // 26:宠物洗点结果
    PACKET_CG_ASK_HIDE_FELLOW               = 4891, // 27:隐藏宠物
    PACKET_CG_ASK_SHOW_FELLOW               = 4892, // 28:显示宠物
    PACKET_GC_UPDATE_ACTIVE_FELLOWSKILL     = 4893, // 29:更新激活的宠物技能
    PACKET_CG_EQUIP_FELLOW_SKILL            = 4894, // 30:装备宠物技能
    PACKET_GC_EQUIP_FELLOW_SKILL_RET        = 4895, // 31:装备宠物技能结果
    PACKET_CG_UNEQUIP_FELLOW_SKILL          = 4896, // 32:卸载宠物技能
    PACKET_GC_UNEQUIP_FELLOW_SKILL_RET      = 4897, // 33:卸载宠物技能结果
    PACKET_CG_LEVELUP_FELLOW_SKILL          = 4898, // 34:升级宠物技能
    PACKET_GC_LEVELUP_FELLOW_SKILL_RET      = 4899, // 35:升级宠物技能结果

    //排行榜: id = 20, name = rank
    PACKET_CG_ASK_RANK                      = 5126, // 6:查询排行榜
    PACKET_GC_RET_RANK                      = 5127, // 7:排行榜查询结果

    //系统引导: id = 21, name = guide
    PACKET_GC_UI_NEWPLAYERGUIDE             = 5377, // 1:
    PACKET_GC_PLAY_MODELSOTRY               = 5378, // 2:
    PACKET_GC_UI_OPERATION                  = 5380, // 4:
    PACKET_GC_OPENFUNCTION                  = 5381, // 5:系统功能开启
    PACKET_GC_SYNC_COMMONDATA               = 5382, // 6:系统功能开启
    PACKET_GC_SYNC_COMMONFLAG               = 5383, // 7:系统功能开启标记
    PACKET_CG_ASK_NEWPLAYER_CREATE_NPC      = 5384, // 8:生成npc
    PACKET_CG_GUIDE_STEP                    = 5385, // 9:新手指引步骤
    PACKET_GC_DO_CLIENT_SCRIPT              = 5386, // 10:执行客户端脚本
    PACKET_CG_JUQINGITEM_PLAYEFFECT         = 5387, // 11:
    PACKET_GC_RET_JUQINGITEM_PLAYEFFECT     = 5388, // 12:

    //其他: id = 22, name = other
    PACKET_GC_USERTIP                       = 5634, // 2:
    PACKET_GC_PLAY_SOUNDS                   = 5635, // 3:
    PACKET_CG_CHANGE_SHOWFASHION            = 5639, // 7:
    PACKET_GC_CHANGE_SHOWFASHION            = 5640, // 8:
    PACKET_GC_LOGIN_QUEUE_STATUS            = 5661, // 29:
    PACKET_GC_SYNC_AWARDTABLE               = 5687, // 55:
    PACKET_CG_REQ_MARRAGE                   = 5698, // 66:
    PACKET_GC_RET_MARRAGE                   = 5699, // 67:
    PACKET_GC_SYN_LOVERINFO                 = 5704, // 72:
    PACKET_GC_PUSH_NOTIFICATION             = 5709, // 77:
    PACKET_CG_ASK_NEWONLINEAWARD            = 5711, // 79:
    PACKET_GC_NEWONLINEAWARD_DATA           = 5712, // 80:
    PACKET_GC_SYNC_NEWONLINEAWARDTABLE      = 5713, // 81:
    PACKET_GC_SYNC_PAY_ACTIVITY_DATA        = 5719, // 87:
    PACKET_CG_ASK_PAY_ACTIVITY_PRIZE        = 5720, // 88:
    PACKET_GC_ASK_PAY_ACTIVITY_PRIZE_RET    = 5721, // 89:
    PACKET_GC_PLAY_YANHUA                   = 5748, // 116:
    PACKET_GC_CREATE_YANHUA                 = 5749, // 117:
    PACKET_GC_OPEN_SHAREWINDOW              = 5759, // 127:
    PACKET_GC_UPDATE_RECHARGESTATE          = 5762, // 130:
    PACKET_GC_RET_ISWILDENEMY2USER          = 5767, // 135:
    PACKET_GC_RESTAURANT_VISITFRIENDINFO    = 5768, // 136:
    PACKET_CG_ASK_NEW7DAYONLINEAWARD        = 5771, // 139:
    PACKET_GC_NEW7DAYONLINEAWARD_DATA       = 5772, // 140:
    PACKET_GC_SYNC_NEW7DAYONLINEAWARDTABLE  = 5773, // 141:
    PACKET_CG_ASK_SPECIALAWARD              = 5775, // 143:
    PACKET_GC_TODAY_FIRST_LOGIN             = 5776, // 144:

    //华山副本: id = 23, name = single_pvp
    PACKET_CG_HUASHAN_PVP_REGISTER          = 5889, // 1:报名
    PACKET_CG_HUASHAN_PVP_MEMBERLIST        = 5890, // 2:申请名单列表
    PACKET_GC_HUASHAN_PVP_MEMBERLIST        = 5891, // 3:服务器返回名单列表
    PACKET_GC_HUASHAN_PVP_STATE             = 5892, // 4:服务器返回当前状态
    PACKET_GC_HUASHAN_PVP_SELFPOSITION      = 5893, // 5:服务器返回玩家的排名
    PACKET_GC_HUASHAN_PVP_SHOWSEARCH        = 5894, // 6:服务器返回查询进度
    PACKET_GC_HUASHAN_PVP_OPPONENTVIEW      = 5895, // 7:返回对手视图
    PACKET_GC_HUASHAN_PVP_ASSIST_STATE      = 5896, // 8:返回参赛状态
    PACKET_CG_HUASHAN_ASSIST_REQ            = 5897, // 9:申请参赛状态
    PACKET_CG_REQ_HUASHAN_PKINFO            = 5898, // 10:申请当前轮次信息
    PACKET_GC_RET_HUASHAN_PKINFO            = 5899, // 11:返回当前轮次比赛信息
    PACKET_CG_ASK_HUASHANPVP_STATE          = 5900, // 12:申请当前状态

    //帮战: id = 24, name = guild_war
    PACKET_CG_PRELIMINARY_APPLYGUILDWAR     = 6145, // 1:申请报名参加海选赛
    PACKET_CG_ASK_PRELIMINARY_WARINFO       = 6146, // 2:查询申请海选赛信息
    PACKET_GC_RET_PRELIMINARY_WARINFO       = 6147, // 3:返回本家族家族战信息
    PACKET_GC_SHOW_PRELIMINARY_WARRET       = 6148, // 4:返回本家族家族战胜负结果
    PACKET_CG_ASK_CHALLENGEGUILDWAR         = 6149, // 5:废弃(api)
    PACKET_CG_RET_STARTWAR                  = 6150, // 6:玩家是否参加家族战
    PACKET_CG_ASK_CURGUILDWARTYPE           = 6151, // 7:打开家族战界面请求信息
    PACKET_GC_RET_CURGUILDWARTYPE           = 6152, // 8:返回当前家族战信息
    PACKET_CG_FIGHTGUILDWARPOINT            = 6153, // 9:占点
    PACKET_GC_ASK_STARTGUILDWAR             = 6154, // 10:询问玩家是否参与帮战
    PACKET_CG_ASK_GUILDWILDWAR              = 6155, // 11:需要知道客户端发送逻辑
    PACKET_CG_ASK_ENEMYGUILDINFO            = 6156, // 12:需要知道客户端发送逻辑
    PACKET_GC_RET_ENEMYGUILDINFO            = 6157, // 13:需要知道客户端接收逻辑
    PACKET_CG_ASK_FINALGUILDWARGROUPINFO    = 6158, // 14:
    PACKET_CG_ASK_FINALGUILDWARPOINTINFO    = 6159, // 15:
    PACKET_GC_RET_FINALGUILDWARGROUPINFO    = 6160, // 16:
    PACKET_GC_RET_FINALGUILDWARPOINTINFO    = 6161, // 17:

    //好友雇佣: id = 25, name = employee
    PACKET_CG_MERCENARY_LIST_REQ            = 6401, // 1:
    PACKET_GC_MERCENARY_LIST_RES            = 6402, // 2:
    PACKET_GC_MERCENARY_LEFTTIMES           = 6403, // 3:
    PACKET_GC_MERCENARY_EMPLOYLIST          = 6404, // 4:
    PACKET_CG_MERCENARY_REQ                 = 6405, // 5:

    //酒馆: id = 26, name = restaurant
    PACKET_GC_RESTAURANT_UPDATE             = 6657, // 1:
    PACKET_GC_RESTAURANT_DESTUPDATE         = 6658, // 2:
    PACKET_GC_RESTAURANT_LEVELUPDATE        = 6659, // 3:
    PACKET_CG_RESTAURANT_PREPAREFOOD        = 6660, // 4:
    PACKET_CG_RESTAURANT_BILLINGALL         = 6661, // 5:
    PACKET_CG_RESTAURANT_FINISHPREPARE      = 6662, // 6:
    PACKET_CG_RESTAURANT_ACTIVEDESK         = 6663, // 7:
    PACKET_CG_RESTAURANT_VISITFRIEND        = 6664, // 8:

    //宗派: id = 27, name = master
    PACKET_CG_MASTER_REQ_LIST               = 6913, // 1:
    PACKET_GC_MASTER_RET_LIST               = 6914, // 2:
    PACKET_CG_MASTER_REQ_INFO               = 6915, // 3:
    PACKET_GC_MASTER_RET_INFO               = 6916, // 4:
    PACKET_CG_MASTER_REQ_CHANGE_NOTICE      = 6917, // 5:
    PACKET_CG_MASTER_CREATE                 = 6918, // 6:
    PACKET_GC_MASTER_CREATE                 = 6919, // 7:
    PACKET_CG_MASTER_JOIN                   = 6920, // 8:
    PACKET_GC_MASTER_JOIN                   = 6921, // 9:
    PACKET_CG_MASTER_LEAVE                  = 6922, // 10:
    PACKET_GC_MASTER_LEAVE                  = 6923, // 11:
    PACKET_CG_MASTER_KICK                   = 6924, // 12:
    PACKET_GC_MASTER_KICK                   = 6925, // 13:
    PACKET_CG_MASTER_APPROVE_RESERVE        = 6926, // 14:
    PACKET_GC_MASTER_APPROVE_RESERVE        = 6927, // 15:
    PACKET_GC_SYN_TORCH_VALUE               = 6935, // 23:
    PACKET_CG_ASK_TORCH_VALUE               = 6936, // 24:

    //副本: id = 28, name = dungeon
    PACKET_GC_COUNTDOWN                     = 7169, // 1:副本倒计时
    PACKET_GC_SYNC_COPYSCENENUMBER          = 7170, // 2:
    PACKET_CG_COPYSCENERESET                = 7171, // 3:
    PACKET_GC_SHOWPKNOTICE                  = 7172, // 4:显示pk结果
    PACKET_GC_SYNC_COPYSCENEEXTRANUMBER     = 7173, // 5:
    PACKET_CG_ASK_COPYSCENE_SWEEP           = 7174, // 6:扫荡
    PACKET_GC_RET_COPYSCENE_SWEEP           = 7175, // 7:扫荡结果
    PACKET_GC_COPYSCENE_RESULT              = 7176, // 8:副本结果
    PACKET_CG_ASK_COPYSCENE_REWARD          = 7177, // 9:领取副本奖励
    PACKET_GC_RET_COPYSCENE_REWARD          = 7178, // 10:领取副本奖励结果
    PACKET_CG_CH_MON_FIGHT                  = 7179, // 11:副本中改变怪物的战斗状态
    PACKET_CG_DUEL_REQUEST                  = 7180, // 12:
    PACKET_GC_DUEL_REQUESTU                 = 7181, // 13:
    PACKET_CG_DUEL_RESPONSE                 = 7182, // 14:
    PACKET_GC_DUEL_STATE                    = 7183, // 15:

    //设置: id = 29, name = setting
    PACKET_CG_SET_DEATH_PUSH                = 7425, // 1:设置死亡push开关
    PACKET_CG_ASK_SETCOMMONFLAG             = 7426, // 2:系统功能设置标记
    PACKET_GC_ASK_COMMONFLAG_RET            = 7427, // 3:系统功能设置标记结果

    //vip: id = 30, name = vip
    PACKET_CG_CYPAY_SUCCESS                 = 7681, // 1:
    PACKET_CG_ASK_ISRECHARGE_ENABLE         = 7682, // 2:
    PACKET_CG_ADDPAY_TEST                   = 7683, // 3:充值测试
    PACKET_GC_ADDPAY_TEST                   = 7684, // 4:充值测试结果

    //交易(拍卖行,寄售): id = 31, name = market
    PACKET_CG_CONSIGNSALEITEM               = 7937, // 1:玩家寄售物品
    PACKET_CG_CANCELCONSIGNSALEITEM         = 7938, // 2:玩家取消寄售物品
    PACKET_CG_ASK_MYCONSIGNSALEITEM         = 7939, // 3:玩家查询自己当前寄售的物品
    PACKET_GC_RET_MYCONSIGNSALEITEM         = 7940, // 4:查询玩家自己当前寄售物品的物品返回
    PACKET_CG_ASK_CONSIGNSALEITEMINFO       = 7941, // 5:玩家查询寄售物品信息[自定义查询]
    PACKET_GC_RET_CONSIGNSALEITEMINFO       = 7942, // 6:玩家查询寄售物品信息返回值
    PACKET_CG_BUY_CONSIGNSALEITEMINFO       = 7943, // 7:玩家购买寄售物品

    //侠客: id = 32, name = swordsman
    PACKET_CG_VISIT_SWORDSMAN               = 8193, // 1:
    PACKET_CG_SWORDSMAN_LEVELUP             = 8194, // 2:
    PACKET_CG_BUY_SWORDSMAN                 = 8195, // 3:
    PACKET_CG_EQUIP_SWORDSMAN               = 8196, // 4:
    PACKET_CG_UNEQUIP_SWORDSMAN             = 8197, // 5:
    PACKET_GC_UPDATE_SWORDSMAN              = 8198, // 6:
    PACKET_GC_UPDATE_SWORDSMAN_VISITSTATE   = 8199, // 7:
    PACKET_GC_RET_VISIT_SWORDSMAN           = 8200, // 8:
    PACKET_GC_RET_LEVELUP_SWORDSMAN         = 8201, // 9:
    PACKET_CG_LOCK_SWORDSMAN                = 8202, // 10:
    PACKET_CG_UNLOCK_SWORDSMAN              = 8203, // 11:
    PACKET_GC_SWORDSMANPACK_RESIZE          = 8204, // 12:

    //单人竞技场－数据PK: id = 33, name = arena_single
    PACKET_GC_CHALLENGE_MYDATA              = 8449, // 1:
    PACKET_CG_RANDOM_OPPONENT               = 8450, // 2:请求随机对手消息
    PACKET_GC_OPPONENT_LIST                 = 8451, // 3:
    PACKET_CG_CHALLENGERANKLIST_REQ         = 8452, // 4:请求名人录排行榜
    PACKET_GC_CHALLENGERANKLIST             = 8453, // 5:
    PACKET_CG_REQ_CHALLENGE                 = 8454, // 6:
    PACKET_GC_CHALLENGE_REWARD              = 8455, // 7:
    PACKET_GC_CHALLENGE_HISTORY             = 8456, // 8:

    //福利: id = 34, name = weal
    PACKET_CG_DAILYLUCKYDRAW_DRAW           = 8705, // 1:CG_DAILYLUCKYDRAW_DRAW
    PACKET_GC_DAILYLUCKYDRAW_GAINBONUS      = 8706, // 2:GC_DAILYLUCKYDRAW_GAINBONUS
    PACKET_GC_DAILYLUCKYDRAW_UPDATE         = 8707, // 3:GC_DAILYLUCKYDRAW_UPDATE
    PACKET_GC_DAILYLUCKYDRAW_FAIL           = 8708, // 4:GC_DAILYLUCKYDRAW_FAIL
    PACKET_CG_MONEYTREE_ASKAWARD            = 8709, // 5:CG_MONEYTREE_ASKAWARD
    PACKET_GC_MONEYTREE_DATA                = 8710, // 6:GC_MONEYTREE_DATA
    PACKET_CG_REQUEST_CDKEY                 = 8711, // 7:玩家兑换码

    //充值活动: id = 35, name = rebate
    PACKET_CG_ASK_PAY_ACTIVITY              = 8961, // 1:CG_ASK_PAY_ACTIVITY
    PACKET_GC_ASK_PAY_ACTIVITY_RET          = 8962, // 2:GC_ASK_PAY_ACTIVITY_RET
    PACKET_CG_ASK_BINDNUMBER                = 8963, // 3:CG_ASK_BINDNUMBER
    PACKET_GC_ASK_BINDNUMBER_RET            = 8964, // 4:GC_ASK_BINDNUMBER_RET
    PACKET_CG_SEND_FANKUI                   = 8965, // 5:CG_SEND_FANKUI
    PACKET_GC_RET_FANKUI                    = 8966, // 6:GC_RET_FANKUI
    PACKET_GC_RET_ACTIVE_YUEKA              = 8967, // 7:GC_RET_ACTIVE_YUEKA
    PACKET_GC_RET_ACTIVE_LEICHONG           = 8968, // 8:GC_RET_ACTIVE_LEICHONG
    PACKET_CG_ACK_ACTIVE_LEICHONG           = 8969, // 9:CG_ACK_ACTIVE_LEICHONG

    //Other Messages
    PACKET_GC_SERVER_SERIOUSERROR          , // send server error
    PACKET_GC_SEND_FASHIONINFO             , // Server Send Fshion Info
    PACKET_GC_SYNC_FASHION                 , // Server Sync All Fshion
    PACKET_CG_TAKEOFF_FASHION              , // Client Wear Fashion
    PACKET_GC_SEND_CURFASHION              , // Server Send Cur FashionID
    PACKET_GC_DYNAMICOBSTACLE_OPT          , // Sever commond Create dynamic obstacle

    PACKET_SIZE
}