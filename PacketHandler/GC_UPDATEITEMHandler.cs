//This code create by CodeEngine

using System;
using Module.Log;
using Google.ProtocolBuffers;
using System.Collections;
using Games.Item;
using Games.GlobeDefine;

namespace SPacket.SocketInstance
{
    public class GC_UPDATEITEMHandler : Ipacket
    {
        public uint Execute(PacketDistributed ipacket)
        {
            GC_UPDATEITEM packet = (GC_UPDATEITEM)ipacket;
            if (null == packet) return (uint)PACKET_EXE.PACKET_EXE_ERROR;
            int packtype = packet.Packtype;
            int packindex = packet.Packindex;
            GameItemContainer.Type containertype = (GameItemContainer.Type)packtype;
            //ȡ����Ʒ����
            GameItemContainer Container = GameManager.gameManager.PlayerDataPool.GetItemContainer(containertype);
            if (Container != null)
            {
                //ȡ����Ʒ
                GameItem item = Container.GetItem(packindex);               
                if (item != null)
                {
                    int nRawId = item.DataID;
                    UInt64 RawGuidID = item.Guid;
                    //ID
                    item.DataID = packet.Dataid;
                    //GUID
                    item.Guid = packet.Guid;
                    //��
                    if (packet.HasBindflag)
                    {
                        if (packet.Bindflag == 1)
                        {
                            item.BindFlag = true;
                        }
                        else
                        {
                            item.BindFlag = false;
                        }
                    }
                    else
                    {
                        item.BindFlag = false;
                    }
                    //��������
                    if (packet.HasStackcount)
                    {
                        item.StackCount = packet.Stackcount;
                    }
                    else
                    {
                        item.StackCount = 1;
                    }
                    //����ʱ��
                    item.CreateTime = packet.Createtime;
                    //ǿ���ȼ�
                    if (packet.HasEnchancelevel)
                    {
                        item.EnchanceLevel = packet.Enchancelevel;
                    }
                    else
                    {
                        item.EnchanceLevel = 0;
                    }
                    //ǿ������
                    if (packet.HasEnchanceexp)
                    {
                        item.EnchanceExp = packet.Enchanceexp;
                    }
                    else
                    {
                        item.EnchanceExp = 0;
                    }
                    //ǿ���ܾ���
                    if (packet.HasEnctotaltexp)
                    {
                        item.EnchanceTotalExp = packet.Enctotaltexp;
                    }
                    else
                    {
                        item.EnchanceTotalExp = 0;
                    }
                    //���ǵȼ�
                    if (packet.HasStarlevel)
                    {
                        item.StarLevel = packet.Starlevel;
                    }
                    else
                    {
                        item.StarLevel = 0;
                    }
                    //���Ǵ���
                    if (packet.HasStartimes)
                    {
                        item.StarTimes = packet.Startimes;
                    }
                    else
                    {
                        item.StarTimes = 0;
                    }
                    //��̬����
                    if (packet.HasDynamicdata1)
                    {
                        item.DynamicData[0] = packet.Dynamicdata1;
                    }
                    else
                    {
                        item.DynamicData[0] = -1;
                    }
                    if (packet.HasDynamicdata2)
                    {
                        item.DynamicData[1] = packet.Dynamicdata2;
                    }
                    else
                    {
                        item.DynamicData[1] = -1;
                    }
                    if (packet.HasDynamicdata3)
                    {
                        item.DynamicData[2] = packet.Dynamicdata3;
                    }
                    else
                    {
                        item.DynamicData[2] = -1;
                    }
                    if (packet.HasDynamicdata4)
                    {
                        item.DynamicData[3] = packet.Dynamicdata4;
                    }
                    else
                    {
                        item.DynamicData[3] = -1;
                    }
                    if (packet.HasDynamicdata5)
                    {
                        item.DynamicData[4] = packet.Dynamicdata5;
                    }
                    else
                    {
                        item.DynamicData[4] = -1;
                    }
                    if (packet.HasDynamicdata6)
                    {
                        item.DynamicData[5] = packet.Dynamicdata6;
                    }
                    else
                    {
                        item.DynamicData[5] = -1;
                    }
                    if (packet.HasDynamicdata7)
                    {
                        item.DynamicData[6] = packet.Dynamicdata7;
                    }
                    else
                    {
                        item.DynamicData[6] = -1;
                    }
                    if (packet.HasDynamicdata8)
                    {
                        item.DynamicData[7] = packet.Dynamicdata8;
                    }
                    else
                    {
                        item.DynamicData[7] = -1;
                    }

                    //���½���
                    switch (containertype)
                    {
                        //��Ʒ����
                        case GameItemContainer.Type.TYPE_BACKPACK:
                            {
                                if (BackPackLogic.Instance() != null)
                                {
                                    BackPackLogic.Instance().UpdateBackPack();
                                }
                              
                                //��ʯ����
                                if (GemLogic.Instance() != null)
                                {
                                    GemLogic.Instance().UpdateGemItemList();
                                }
                                //�Զ�ѡ��ҩ
                                if (Singleton<ObjManager>.GetInstance().MainPlayer)
                                {
                                    Singleton<ObjManager>.GetInstance().MainPlayer.UpdateSelectDrug();
                                    //����ͷ��ͼ����Ϣ
                                    if ((nRawId >= (int)GameDefine_Globe.AUTOCOMBAT_DRUG_ID.AUTO_DRUG_START_HP &&
                                        nRawId <= (int)GameDefine_Globe.AUTOCOMBAT_DRUG_ID.AUTO_DRUG_END_HP)
                                        || (nRawId >= (int)GameDefine_Globe.AUTOCOMBAT_DRUG_ID.AUTO_DRUG_START_MP &&
                                        nRawId <= (int)GameDefine_Globe.AUTOCOMBAT_DRUG_ID.AUTO_DRUG_END_MP)
                                        || (item.DataID >= (int)GameDefine_Globe.AUTOCOMBAT_DRUG_ID.AUTO_DRUG_START_HP &&
                                        item.DataID <= (int)GameDefine_Globe.AUTOCOMBAT_DRUG_ID.AUTO_DRUG_END_HP)
                                        || (item.DataID >= (int)GameDefine_Globe.AUTOCOMBAT_DRUG_ID.AUTO_DRUG_START_MP &&
                                        item.DataID <= (int)GameDefine_Globe.AUTOCOMBAT_DRUG_ID.AUTO_DRUG_END_MP))
                                    {
                                        GameViewModel.Get<MainPlayerViewModel>().BackPackChange();
                                    }
                                    //�Զ�����
                                    if (item.DataID != -1)
                                    {
                                        Singleton<ObjManager>.GetInstance().MainPlayer.UpdateSellItem(packindex);
                                    }
                                }
                                // Ǭ����
                                if (QianKunDaiLogic.Instance() != null && QianKunDaiLogic.Instance().gameObject.activeSelf)
                                {
                                    QianKunDaiLogic.Instance().HandleUpdateItemPacket();
                                }
                                // �����
                                if (LivingSkillLogic.Instance() != null)
                                {
                                    LivingSkillLogic.Instance().HandleUpdateItem();
                                }
                                //�ֿ����
                                if (CangKuLogic.Instance() != null)
                                {
                                    CangKuLogic.Instance().UpdateBackPack();
                                }
                                //ʦ���̵�
                                if (null != MasterWindow.Instance())
                                {
                                    MasterWindow.Instance().UpdateQingYi();
                                }
                            }
                            break;
                        //װ����λ
                        case GameItemContainer.Type.TYPE_EQUIPPACK:
                            {
                                if (BackPackLogic.Instance() != null)
                                {
                                    BackPackLogic.Instance().UpdateEquipPack();
                                }
                                if (RoleViewLogic.Instance() != null)
                                {
                                    RoleViewLogic.Instance().UpdateEquipPack();
                                }
                                //�Զ�ǿ��װ��ѡ��
                                if (Singleton<ObjManager>.GetInstance().MainPlayer
                                    && VipData.GetVipLv() >= GlobeVar.USE_AUTOFIGHT_VIPLEVEL
                                    && Singleton<ObjManager>.GetInstance().MainPlayer.BaseAttr.Level >= GlobeVar.MAX_AUTOEQUIT_LIVE )
                                {
                                    if (RawGuidID == Singleton<ObjManager>.GetInstance().MainPlayer.AutoEquipGuid)
                                    {
                                        if (item.IsValid())
                                        {
                                            Singleton<ObjManager>.GetInstance().MainPlayer.AutoEquipGuid = item.Guid;
                                        }
                                        else
                                        {
                                            Singleton<ObjManager>.GetInstance().MainPlayer.AutoEquipGuid = GlobeVar.INVALID_GUID;
                                            Singleton<ObjManager>.GetInstance().MainPlayer.UpdateSelectEquip();
                                        }
                                    }
                                }
                            }
                            break;

                        case GameItemContainer.Type.TYPE_BUYBACKPACK:
                            {
                                SysShopController sysShop = UIControllerBase<SysShopController>.Instance();
                                if (sysShop != null)
                                {
                                    sysShop.UpdateBuyBackItems();
                                }
                            }
                            break;
                        case GameItemContainer.Type.TYPE_GUILDSHOP:
                            {
                                if (null != GuildWindow.Instance())
                                {
                                    GuildWindow.Instance().UpdateGuildShopContribute();
                                }
                            }
                            break;
						case GameItemContainer.Type.TYPE_STORAGEPACK:
							{
								if (null != CangKuLogic.Instance())
								{
									CangKuLogic.Instance().UpdateCangKu();
								}
							}
							break;
                    };
                }
            }
            //enter your logic
            return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
        }
    }
}
