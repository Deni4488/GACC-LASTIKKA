namespace gacc
{
    public static class DBImage
    {
        /// <summary>
        ///  АДАПТЕРЫ ПОДКЛЮЧЕНИЯ К ТАБЛИЦАМ БД
        /// </summary>
        public static dbDataSetTableAdapters.usersTableAdapter uta = new dbDataSetTableAdapters.usersTableAdapter();
        public static dbDataSetTableAdapters.counterpartiesTableAdapter cpta = new dbDataSetTableAdapters.counterpartiesTableAdapter();
        public static dbDataSetTableAdapters.query_CounterpartyListTableAdapter cplta = new dbDataSetTableAdapters.query_CounterpartyListTableAdapter();
        public static dbDataSetTableAdapters.groupsTableAdapter grta = new dbDataSetTableAdapters.groupsTableAdapter();
        public static dbDataSetTableAdapters.query_StatisticSellOfCounterpertiesTableAdapter qscpta = new dbDataSetTableAdapters.query_StatisticSellOfCounterpertiesTableAdapter();
        public static dbDataSetTableAdapters.goodsstoreTableAdapter gsta = new dbDataSetTableAdapters.goodsstoreTableAdapter();
        public static dbDataSetTableAdapters.goodsTableAdapter gta = new dbDataSetTableAdapters.goodsTableAdapter();
        public static dbDataSetTableAdapters.query_ProviderPricesTableAdapter qpp = new dbDataSetTableAdapters.query_ProviderPricesTableAdapter();
        public static dbDataSetTableAdapters.query_GoodsAllTableAdapter gall = new dbDataSetTableAdapters.query_GoodsAllTableAdapter();
        public static dbDataSetTableAdapters.query_GoodsCountTableAdapter qgc = new dbDataSetTableAdapters.query_GoodsCountTableAdapter();
        public static dbDataSetTableAdapters.manufacturersTableAdapter mta = new dbDataSetTableAdapters.manufacturersTableAdapter();
        public static dbDataSetTableAdapters.shopsTableAdapter sta = new dbDataSetTableAdapters.shopsTableAdapter();
        public static dbDataSetTableAdapters.query_GoodsInStoreTableAdapter gista = new dbDataSetTableAdapters.query_GoodsInStoreTableAdapter();
        public static dbDataSetTableAdapters.providersTableAdapter pta = new dbDataSetTableAdapters.providersTableAdapter();
        public static dbDataSetTableAdapters.query_ProviderPriceListTableAdapter qpplta = new dbDataSetTableAdapters.query_ProviderPriceListTableAdapter();
        public static dbDataSetTableAdapters.providerpricesTableAdapter ppta = new dbDataSetTableAdapters.providerpricesTableAdapter();
        public static dbDataSetTableAdapters.query_DemandsListTableAdapter qdlta = new dbDataSetTableAdapters.query_DemandsListTableAdapter();
        public static dbDataSetTableAdapters.query_DemandContentListTableAdapter qgclta = new dbDataSetTableAdapters.query_DemandContentListTableAdapter();
        public static dbDataSetTableAdapters.demandsTableAdapter dta = new dbDataSetTableAdapters.demandsTableAdapter();
        public static dbDataSetTableAdapters.demandcontentTableAdapter dcta = new dbDataSetTableAdapters.demandcontentTableAdapter();
        public static dbDataSetTableAdapters.query_SupplyListTableAdapter qslta = new dbDataSetTableAdapters.query_SupplyListTableAdapter();
        public static dbDataSetTableAdapters.query_SupplyContentListTableAdapter qsclta = new dbDataSetTableAdapters.query_SupplyContentListTableAdapter();
        public static dbDataSetTableAdapters.suppliesTableAdapter supta = new dbDataSetTableAdapters.suppliesTableAdapter();
        public static dbDataSetTableAdapters.supplycontentTableAdapter supcta = new dbDataSetTableAdapters.supplycontentTableAdapter();
        public static dbDataSetTableAdapters.query_SellListTableAdapter qselllta = new dbDataSetTableAdapters.query_SellListTableAdapter();
        public static dbDataSetTableAdapters.query_SellContentListTableAdapter qsellclta = new dbDataSetTableAdapters.query_SellContentListTableAdapter();
        public static dbDataSetTableAdapters.sellTableAdapter sellta = new dbDataSetTableAdapters.sellTableAdapter();
        public static dbDataSetTableAdapters.sellcontentTableAdapter sellcta = new dbDataSetTableAdapters.sellcontentTableAdapter();
        public static dbDataSetTableAdapters.discountsystemTableAdapter dsta = new dbDataSetTableAdapters.discountsystemTableAdapter();

        /// <summary>
        /// ОТОБРАЖЕНИЕ ТАБЛИЦ БД
        /// </summary>
        public static dbDataSet.usersDataTable udt;
        public static dbDataSet.query_StatisticSellOfCounterpertiesDataTable qscp;
        public static dbDataSet.query_GoodsCountDataTable gcdt;
        public static dbDataSet.query_ProviderPricesDataTable ppdt;
        public static dbDataSet.goodsstoreDataTable gsdt;
        public static dbDataSet.shopsDataTable sdt;
        public static dbDataSet.query_GoodsInStoreDataTable gisdt;
        public static dbDataSet.query_ProviderPriceListDataTable qppldt;
        public static dbDataSet.query_DemandContentListDataTable qdcldt;
        public static dbDataSet.query_SupplyContentListDataTable qscldt;
        public static dbDataSet.query_SellContentListDataTable qsellcldt;
        public static dbDataSet.discountsystemDataTable dsdt;
        public static dbDataSet.query_CounterpartyListDataTable cpldt;
    }
}