using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public sealed class AllDataOrInfoContainer { }

public class DataContainer_PanelCellGameArchive
{    
    public E_GameArchiveLevel e_GameArchiveLevel = E_GameArchiveLevel.None;
    public List<DataContainer_PanelCellTownStore> ListCellStore = new List<DataContainer_PanelCellTownStore>();
    public DataContainer_PanelResTable PanelResTable = new DataContainer_PanelResTable();
    public List<DataContainer_PanelCellItem> ListCellShopItem = new List<DataContainer_PanelCellItem>();

    public string GameArchiveName = "---";
    public string Location = "---";
    public string Week = "0";
    public string Time = "0000/00/00 00:00:00";    

    public DataContainer_PanelCellGameArchive() { }
    public DataContainer_PanelCellGameArchive
    (string GameArchiveName, E_GameArchiveLevel e_GameArchiveLevel, string Location, string Week, string Time, 
    List<DataContainer_PanelCellTownStore> ListCellStore)
    {
        this.GameArchiveName = GameArchiveName;
        this.e_GameArchiveLevel = e_GameArchiveLevel;
        this.Location = Location;
        this.Week = Week;
        this.Time = Time;
        this.ListCellStore = ListCellStore;
    }
}

public class DataContainer_PanelCellTownStore
{
    public E_SpriteNamePanelCellTownStore e_SpriteNamePanelCellTownStore = E_SpriteNamePanelCellTownStore.StoreWood;
    public List<DataContainer_PanelCellItem> DataListCellStoreItem = new List<DataContainer_PanelCellItem>();    
    public int NowWeight = 0;    
    public int NowCapacity = 0;    

    public DataContainer_PanelCellTownStore() { }
    public DataContainer_PanelCellTownStore
    (E_SpriteNamePanelCellTownStore e_SpriteNamePanelCellTownStore)
    {        
        this.e_SpriteNamePanelCellTownStore = e_SpriteNamePanelCellTownStore;        
    }
}

public class DataContainer_PanelCellItem
{
    public E_Location e_Location = E_Location.PanelTownItem;
    public E_SpriteNamePanelCellItem e_SpriteNamePanelCellItem = E_SpriteNamePanelCellItem.ItemFoodCookie;   

    public DataContainer_PanelCellItem() { }
    public DataContainer_PanelCellItem
    (E_Location e_Location, E_SpriteNamePanelCellItem e_SpriteNamePanelCellItem)
    {     
        this.e_Location = e_Location;
        this.e_SpriteNamePanelCellItem = e_SpriteNamePanelCellItem;
    }
}

public class DataContainer_PanelResTable
{
    public int StoreDebris = 0;

    #region AncestralProperty

    public int NowStatue = 0;
    public int NowDeed = 0;
    public int NowBadge = 0;
    public int NowPicture = 0;
    public int NowCrystal = 0;

    public int NowLevelStatue = 1;
    public int NowLevelDeed = 1;
    public int NowLevelBadge = 1;
    public int NowLevelPicture = 1;
    public int NowLevelCrystal = 1;

    public int LevelStepStatue = 10;
    public int LevelStepDeed = 10;
    public int LevelStepBadge = 10;
    public int LevelStepPicture = 10;
    public int LevelStepCrystal = 10;

    public int LevelMaxStatue = 100;
    public int LevelMaxDeed = 100;
    public int LevelMaxBadge = 100;
    public int LevelMaxPicture = 100;
    public int LevelMaxCrystal = 100;

    #endregion

    #region Coin

    public int NowCopper = 0;
    public int NowSilver = 0;
    public int NowGold = 0;
    public int NowPlatinum = 0;

    public int NowLevelCopper = 1;
    public int NowLevelSilver = 1;
    public int NowLevelGold = 1;
    public int NowLevelPlatinum = 1;

    public int LevelStepCopper = 100;
    public int LevelStepSilver = 50;
    public int LevelStepGold = 10;
    public int LevelStepPlatinum = 5;

    public int LevelMaxCopper = 100;
    public int LevelMaxSilver = 100;
    public int LevelMaxGold = 100;
    public int LevelMaxPlatinum = 100;

    public int RateCopperToSilver = 100;
    public int RateSilverToGold = 100;
    public int RateGoldToPlatinum = 100;

    #endregion

    public DataContainer_PanelResTable() { }
}

//特殊的类 用于PanelCellItem 记录打折信息 PriceOffSet 或者其他
//......

public class InfoContainer_Cost
{
    public int Copper;
    public int Silver;
    public int Gold;
    public int Platinum;

    public int Statue;
    public int Deed;
    public int Badge;
    public int Picture;
    public int Crystal;

    public InfoContainer_Cost() { } 
    public InfoContainer_Cost
    (int copper, int silver, int gold, int platinum, 
     int statue, int deed, int badge, int picture, int crystal)
    {
        Copper = copper;
        Silver = silver;
        Gold = gold;
        Platinum = platinum;
        Statue = statue;
        Deed = deed;
        Badge = badge;
        Picture = picture;
        Crystal = crystal;
    }   
}
