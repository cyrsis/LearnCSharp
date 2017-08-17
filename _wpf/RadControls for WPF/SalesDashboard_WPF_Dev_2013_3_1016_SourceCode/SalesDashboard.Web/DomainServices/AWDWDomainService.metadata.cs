
namespace SalesDashboard.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;

    
    // The MetadataTypeAttribute identifies DimAccountMetadata as the class
    // that carries additional metadata for the DimAccount class.
    [MetadataTypeAttribute(typeof(DimAccount.DimAccountMetadata))]
    public partial class DimAccount
    {

        // This class allows you to attach custom attributes to properties
        // of the DimAccount class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimAccountMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimAccountMetadata()
            {
            }

            public Nullable<int> AccountCodeAlternateKey { get; set; }

            public string AccountDescription { get; set; }

            public int AccountKey { get; set; }

            public string AccountType { get; set; }

            public string CustomMemberOptions { get; set; }

            public string CustomMembers { get; set; }

            public string Operator { get; set; }

            public Nullable<int> ParentAccountCodeAlternateKey { get; set; }

            public Nullable<int> ParentAccountKey { get; set; }

            public string ValueType { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimCurrencyMetadata as the class
    // that carries additional metadata for the DimCurrency class.
    [MetadataTypeAttribute(typeof(DimCurrency.DimCurrencyMetadata))]
    public partial class DimCurrency
    {

        // This class allows you to attach custom attributes to properties
        // of the DimCurrency class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimCurrencyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimCurrencyMetadata()
            {
            }

            public string CurrencyAlternateKey { get; set; }

            public int CurrencyKey { get; set; }

            public string CurrencyName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimDateMetadata as the class
    // that carries additional metadata for the DimDate class.
    [MetadataTypeAttribute(typeof(DimDate.DimDateMetadata))]
    public partial class DimDate
    {

        // This class allows you to attach custom attributes to properties
        // of the DimDate class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimDateMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimDateMetadata()
            {
            }

            public byte CalendarQuarter { get; set; }

            public byte CalendarSemester { get; set; }

            public short CalendarYear { get; set; }

            public int DateKey { get; set; }

            public byte DayNumberOfMonth { get; set; }

            public byte DayNumberOfWeek { get; set; }

            public short DayNumberOfYear { get; set; }

            public string EnglishDayNameOfWeek { get; set; }

            public string EnglishMonthName { get; set; }

            public byte FiscalQuarter { get; set; }

            public byte FiscalSemester { get; set; }

            public short FiscalYear { get; set; }

            public string FrenchDayNameOfWeek { get; set; }

            public string FrenchMonthName { get; set; }

            public DateTime FullDateAlternateKey { get; set; }

            public byte MonthNumberOfYear { get; set; }

            public string SpanishDayNameOfWeek { get; set; }

            public string SpanishMonthName { get; set; }

            public byte WeekNumberOfYear { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimDepartmentGroupMetadata as the class
    // that carries additional metadata for the DimDepartmentGroup class.
    [MetadataTypeAttribute(typeof(DimDepartmentGroup.DimDepartmentGroupMetadata))]
    public partial class DimDepartmentGroup
    {

        // This class allows you to attach custom attributes to properties
        // of the DimDepartmentGroup class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimDepartmentGroupMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimDepartmentGroupMetadata()
            {
            }

            public int DepartmentGroupKey { get; set; }

            public string DepartmentGroupName { get; set; }

            public Nullable<int> ParentDepartmentGroupKey { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimGeographyMetadata as the class
    // that carries additional metadata for the DimGeography class.
    [MetadataTypeAttribute(typeof(DimGeography.DimGeographyMetadata))]
    public partial class DimGeography
    {

        // This class allows you to attach custom attributes to properties
        // of the DimGeography class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimGeographyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimGeographyMetadata()
            {
            }

            public string City { get; set; }

            public string CountryRegionCode { get; set; }

            public string EnglishCountryRegionName { get; set; }

            public string FrenchCountryRegionName { get; set; }

            public int GeographyKey { get; set; }

            public string PostalCode { get; set; }

            public Nullable<int> SalesTerritoryKey { get; set; }

            public string SpanishCountryRegionName { get; set; }

            public string StateProvinceCode { get; set; }

            public string StateProvinceName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimOrganizationMetadata as the class
    // that carries additional metadata for the DimOrganization class.
    [MetadataTypeAttribute(typeof(DimOrganization.DimOrganizationMetadata))]
    public partial class DimOrganization
    {

        // This class allows you to attach custom attributes to properties
        // of the DimOrganization class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimOrganizationMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimOrganizationMetadata()
            {
            }

            public Nullable<int> CurrencyKey { get; set; }

            public int OrganizationKey { get; set; }

            public string OrganizationName { get; set; }

            public Nullable<int> ParentOrganizationKey { get; set; }

            public string PercentageOfOwnership { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimProductMetadata as the class
    // that carries additional metadata for the DimProduct class.
    [MetadataTypeAttribute(typeof(DimProduct.DimProductMetadata))]
    public partial class DimProduct
    {

        // This class allows you to attach custom attributes to properties
        // of the DimProduct class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimProductMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimProductMetadata()
            {
            }

            public string ArabicDescription { get; set; }

            public string ChineseDescription { get; set; }

            public string Class { get; set; }

            public string Color { get; set; }

            public Nullable<int> DaysToManufacture { get; set; }

            public Nullable<decimal> DealerPrice { get; set; }

            public Nullable<DateTime> EndDate { get; set; }

            public string EnglishDescription { get; set; }

            public string EnglishProductName { get; set; }

            public bool FinishedGoodsFlag { get; set; }

            public string FrenchDescription { get; set; }

            public string FrenchProductName { get; set; }

            public string GermanDescription { get; set; }

            public string HebrewDescription { get; set; }

            public string JapaneseDescription { get; set; }

            public byte[] LargePhoto { get; set; }

            public Nullable<decimal> ListPrice { get; set; }

            public string ModelName { get; set; }

            public string ProductAlternateKey { get; set; }

            public int ProductKey { get; set; }

            public string ProductLine { get; set; }

            public Nullable<int> ProductSubcategoryKey { get; set; }

            public Nullable<short> ReorderPoint { get; set; }

            public Nullable<short> SafetyStockLevel { get; set; }

            public string Size { get; set; }

            public string SizeRange { get; set; }

            public string SizeUnitMeasureCode { get; set; }

            public string SpanishProductName { get; set; }

            public Nullable<decimal> StandardCost { get; set; }

            public Nullable<DateTime> StartDate { get; set; }

            public string Status { get; set; }

            public string Style { get; set; }

            public string ThaiDescription { get; set; }

            public string TurkishDescription { get; set; }

            public Nullable<double> Weight { get; set; }

            public string WeightUnitMeasureCode { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimProductCategoryMetadata as the class
    // that carries additional metadata for the DimProductCategory class.
    [MetadataTypeAttribute(typeof(DimProductCategory.DimProductCategoryMetadata))]
    public partial class DimProductCategory
    {

        // This class allows you to attach custom attributes to properties
        // of the DimProductCategory class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimProductCategoryMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimProductCategoryMetadata()
            {
            }

            public string EnglishProductCategoryName { get; set; }

            public string FrenchProductCategoryName { get; set; }

            public Nullable<int> ProductCategoryAlternateKey { get; set; }

            public int ProductCategoryKey { get; set; }

            public string SpanishProductCategoryName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimProductSubcategoryMetadata as the class
    // that carries additional metadata for the DimProductSubcategory class.
    [MetadataTypeAttribute(typeof(DimProductSubcategory.DimProductSubcategoryMetadata))]
    public partial class DimProductSubcategory
    {

        // This class allows you to attach custom attributes to properties
        // of the DimProductSubcategory class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimProductSubcategoryMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimProductSubcategoryMetadata()
            {
            }

            public string EnglishProductSubcategoryName { get; set; }

            public string FrenchProductSubcategoryName { get; set; }

            public Nullable<int> ProductCategoryKey { get; set; }

            public Nullable<int> ProductSubcategoryAlternateKey { get; set; }

            public int ProductSubcategoryKey { get; set; }

            public string SpanishProductSubcategoryName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimPromotionMetadata as the class
    // that carries additional metadata for the DimPromotion class.
    [MetadataTypeAttribute(typeof(DimPromotion.DimPromotionMetadata))]
    public partial class DimPromotion
    {

        // This class allows you to attach custom attributes to properties
        // of the DimPromotion class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimPromotionMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimPromotionMetadata()
            {
            }

            public Nullable<double> DiscountPct { get; set; }

            public Nullable<DateTime> EndDate { get; set; }

            public string EnglishPromotionCategory { get; set; }

            public string EnglishPromotionName { get; set; }

            public string EnglishPromotionType { get; set; }

            public string FrenchPromotionCategory { get; set; }

            public string FrenchPromotionName { get; set; }

            public string FrenchPromotionType { get; set; }

            public Nullable<int> MaxQty { get; set; }

            public Nullable<int> MinQty { get; set; }

            public Nullable<int> PromotionAlternateKey { get; set; }

            public int PromotionKey { get; set; }

            public string SpanishPromotionCategory { get; set; }

            public string SpanishPromotionName { get; set; }

            public string SpanishPromotionType { get; set; }

            public DateTime StartDate { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimResellerMetadata as the class
    // that carries additional metadata for the DimReseller class.
    [MetadataTypeAttribute(typeof(DimReseller.DimResellerMetadata))]
    public partial class DimReseller
    {

        // This class allows you to attach custom attributes to properties
        // of the DimReseller class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimResellerMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimResellerMetadata()
            {
            }

            public string AddressLine1 { get; set; }

            public string AddressLine2 { get; set; }

            public Nullable<decimal> AnnualRevenue { get; set; }

            public Nullable<decimal> AnnualSales { get; set; }

            public string BankName { get; set; }

            public string BusinessType { get; set; }

            public Nullable<int> FirstOrderYear { get; set; }

            public Nullable<int> GeographyKey { get; set; }

            public Nullable<int> LastOrderYear { get; set; }

            public Nullable<decimal> MinPaymentAmount { get; set; }

            public Nullable<byte> MinPaymentType { get; set; }

            public Nullable<int> NumberEmployees { get; set; }

            public string OrderFrequency { get; set; }

            public Nullable<byte> OrderMonth { get; set; }

            public string Phone { get; set; }

            public string ProductLine { get; set; }

            public string ResellerAlternateKey { get; set; }

            public int ResellerKey { get; set; }

            public string ResellerName { get; set; }

            public Nullable<int> YearOpened { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimSalesReasonMetadata as the class
    // that carries additional metadata for the DimSalesReason class.
    [MetadataTypeAttribute(typeof(DimSalesReason.DimSalesReasonMetadata))]
    public partial class DimSalesReason
    {

        // This class allows you to attach custom attributes to properties
        // of the DimSalesReason class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimSalesReasonMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimSalesReasonMetadata()
            {
            }

            public int SalesReasonAlternateKey { get; set; }

            public int SalesReasonKey { get; set; }

            public string SalesReasonName { get; set; }

            public string SalesReasonReasonType { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimSalesTerritoryMetadata as the class
    // that carries additional metadata for the DimSalesTerritory class.
    [MetadataTypeAttribute(typeof(DimSalesTerritory.DimSalesTerritoryMetadata))]
    public partial class DimSalesTerritory
    {

        // This class allows you to attach custom attributes to properties
        // of the DimSalesTerritory class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimSalesTerritoryMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimSalesTerritoryMetadata()
            {
            }

            public Nullable<int> SalesTerritoryAlternateKey { get; set; }

            public string SalesTerritoryCountry { get; set; }

            public string SalesTerritoryGroup { get; set; }

            public int SalesTerritoryKey { get; set; }

            public string SalesTerritoryRegion { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DimScenarioMetadata as the class
    // that carries additional metadata for the DimScenario class.
    [MetadataTypeAttribute(typeof(DimScenario.DimScenarioMetadata))]
    public partial class DimScenario
    {

        // This class allows you to attach custom attributes to properties
        // of the DimScenario class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DimScenarioMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DimScenarioMetadata()
            {
            }

            public int ScenarioKey { get; set; }

            public string ScenarioName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactAdditionalInternationalProductDescriptionMetadata as the class
    // that carries additional metadata for the FactAdditionalInternationalProductDescription class.
    [MetadataTypeAttribute(typeof(FactAdditionalInternationalProductDescription.FactAdditionalInternationalProductDescriptionMetadata))]
    public partial class FactAdditionalInternationalProductDescription
    {

        // This class allows you to attach custom attributes to properties
        // of the FactAdditionalInternationalProductDescription class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactAdditionalInternationalProductDescriptionMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactAdditionalInternationalProductDescriptionMetadata()
            {
            }

            public string CultureName { get; set; }

            public string ProductDescription { get; set; }

            public int ProductKey { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactCallCenterMetadata as the class
    // that carries additional metadata for the FactCallCenter class.
    [MetadataTypeAttribute(typeof(FactCallCenter.FactCallCenterMetadata))]
    public partial class FactCallCenter
    {

        // This class allows you to attach custom attributes to properties
        // of the FactCallCenter class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactCallCenterMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactCallCenterMetadata()
            {
            }

            public int AutomaticResponses { get; set; }

            public short AverageTimePerIssue { get; set; }

            public int Calls { get; set; }

            public int DateKey { get; set; }

            public int FactCallCenterID { get; set; }

            public short IssuesRaised { get; set; }

            public short LevelOneOperators { get; set; }

            public short LevelTwoOperators { get; set; }

            public int Orders { get; set; }

            public double ServiceGrade { get; set; }

            public string Shift { get; set; }

            public short TotalOperators { get; set; }

            public string WageType { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactCurrencyRateMetadata as the class
    // that carries additional metadata for the FactCurrencyRate class.
    [MetadataTypeAttribute(typeof(FactCurrencyRate.FactCurrencyRateMetadata))]
    public partial class FactCurrencyRate
    {

        // This class allows you to attach custom attributes to properties
        // of the FactCurrencyRate class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactCurrencyRateMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactCurrencyRateMetadata()
            {
            }

            public double AverageRate { get; set; }

            public int CurrencyKey { get; set; }

            public int DateKey { get; set; }

            public double EndOfDayRate { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactFinanceMetadata as the class
    // that carries additional metadata for the FactFinance class.
    [MetadataTypeAttribute(typeof(FactFinance.FactFinanceMetadata))]
    public partial class FactFinance
    {

        // This class allows you to attach custom attributes to properties
        // of the FactFinance class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactFinanceMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactFinanceMetadata()
            {
            }

            public int AccountKey { get; set; }

            public double Amount { get; set; }

            public int DateKey { get; set; }

            public int DepartmentGroupKey { get; set; }

            public int FinanceKey { get; set; }

            public int OrganizationKey { get; set; }

            public int ScenarioKey { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactInternetSalesMetadata as the class
    // that carries additional metadata for the FactInternetSales class.
    [MetadataTypeAttribute(typeof(FactInternetSales.FactInternetSalesMetadata))]
    public partial class FactInternetSales
    {

        // This class allows you to attach custom attributes to properties
        // of the FactInternetSales class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactInternetSalesMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactInternetSalesMetadata()
            {
            }

            public string CarrierTrackingNumber { get; set; }

            public int CurrencyKey { get; set; }

            public int CustomerKey { get; set; }

            public string CustomerPONumber { get; set; }

            public double DiscountAmount { get; set; }

            public int DueDateKey { get; set; }

            public decimal ExtendedAmount { get; set; }

            public decimal Freight { get; set; }

            public int OrderDateKey { get; set; }

            public short OrderQuantity { get; set; }

            public int ProductKey { get; set; }

            public decimal ProductStandardCost { get; set; }

            public int PromotionKey { get; set; }

            public byte RevisionNumber { get; set; }

            public decimal SalesAmount { get; set; }

            public byte SalesOrderLineNumber { get; set; }

            public string SalesOrderNumber { get; set; }

            public int SalesTerritoryKey { get; set; }

            public int ShipDateKey { get; set; }

            public decimal TaxAmt { get; set; }

            public decimal TotalProductCost { get; set; }

            public decimal UnitPrice { get; set; }

            public double UnitPriceDiscountPct { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactInternetSalesReasonMetadata as the class
    // that carries additional metadata for the FactInternetSalesReason class.
    [MetadataTypeAttribute(typeof(FactInternetSalesReason.FactInternetSalesReasonMetadata))]
    public partial class FactInternetSalesReason
    {

        // This class allows you to attach custom attributes to properties
        // of the FactInternetSalesReason class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactInternetSalesReasonMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactInternetSalesReasonMetadata()
            {
            }

            public byte SalesOrderLineNumber { get; set; }

            public string SalesOrderNumber { get; set; }

            public int SalesReasonKey { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactResellerSalesMetadata as the class
    // that carries additional metadata for the FactResellerSales class.
    [MetadataTypeAttribute(typeof(FactResellerSales.FactResellerSalesMetadata))]
    public partial class FactResellerSales
    {

        // This class allows you to attach custom attributes to properties
        // of the FactResellerSales class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactResellerSalesMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactResellerSalesMetadata()
            {
            }

            public string CarrierTrackingNumber { get; set; }

            public int CurrencyKey { get; set; }

            public string CustomerPONumber { get; set; }

            public Nullable<double> DiscountAmount { get; set; }

            public int DueDateKey { get; set; }

            public int EmployeeKey { get; set; }

            public Nullable<decimal> ExtendedAmount { get; set; }

            public Nullable<decimal> Freight { get; set; }

            public int OrderDateKey { get; set; }

            public Nullable<short> OrderQuantity { get; set; }

            public int ProductKey { get; set; }

            public Nullable<decimal> ProductStandardCost { get; set; }

            public int PromotionKey { get; set; }

            public int ResellerKey { get; set; }

            public Nullable<byte> RevisionNumber { get; set; }

            public Nullable<decimal> SalesAmount { get; set; }

            public byte SalesOrderLineNumber { get; set; }

            public string SalesOrderNumber { get; set; }

            public int SalesTerritoryKey { get; set; }

            public int ShipDateKey { get; set; }

            public Nullable<decimal> TaxAmt { get; set; }

            public Nullable<decimal> TotalProductCost { get; set; }

            public Nullable<decimal> UnitPrice { get; set; }

            public Nullable<double> UnitPriceDiscountPct { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactSalesQuotaMetadata as the class
    // that carries additional metadata for the FactSalesQuota class.
    [MetadataTypeAttribute(typeof(FactSalesQuota.FactSalesQuotaMetadata))]
    public partial class FactSalesQuota
    {

        // This class allows you to attach custom attributes to properties
        // of the FactSalesQuota class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactSalesQuotaMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactSalesQuotaMetadata()
            {
            }

            public byte CalendarQuarter { get; set; }

            public short CalendarYear { get; set; }

            public int DateKey { get; set; }

            public int EmployeeKey { get; set; }

            public decimal SalesAmountQuota { get; set; }

            public int SalesQuotaKey { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies FactSurveyResponseMetadata as the class
    // that carries additional metadata for the FactSurveyResponse class.
    [MetadataTypeAttribute(typeof(FactSurveyResponse.FactSurveyResponseMetadata))]
    public partial class FactSurveyResponse
    {

        // This class allows you to attach custom attributes to properties
        // of the FactSurveyResponse class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FactSurveyResponseMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FactSurveyResponseMetadata()
            {
            }

            public int CustomerKey { get; set; }

            public int DateKey { get; set; }

            public string EnglishProductCategoryName { get; set; }

            public string EnglishProductSubcategoryName { get; set; }

            public int ProductCategoryKey { get; set; }

            public int ProductSubcategoryKey { get; set; }

            public int SurveyResponseKey { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ProspectiveBuyerMetadata as the class
    // that carries additional metadata for the ProspectiveBuyer class.
    [MetadataTypeAttribute(typeof(ProspectiveBuyer.ProspectiveBuyerMetadata))]
    public partial class ProspectiveBuyer
    {

        // This class allows you to attach custom attributes to properties
        // of the ProspectiveBuyer class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProspectiveBuyerMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProspectiveBuyerMetadata()
            {
            }

            public string AddressLine1 { get; set; }

            public string AddressLine2 { get; set; }

            public Nullable<DateTime> BirthDate { get; set; }

            public string City { get; set; }

            public string Education { get; set; }

            public string EmailAddress { get; set; }

            public string FirstName { get; set; }

            public string Gender { get; set; }

            public string HouseOwnerFlag { get; set; }

            public string LastName { get; set; }

            public string MaritalStatus { get; set; }

            public string MiddleName { get; set; }

            public Nullable<byte> NumberCarsOwned { get; set; }

            public Nullable<byte> NumberChildrenAtHome { get; set; }

            public string Occupation { get; set; }

            public string Phone { get; set; }

            public string PostalCode { get; set; }

            public string ProspectAlternateKey { get; set; }

            public int ProspectiveBuyerKey { get; set; }

            public string Salutation { get; set; }

            public string StateProvinceCode { get; set; }

            public Nullable<byte> TotalChildren { get; set; }

            public Nullable<int> Unknown { get; set; }

            public Nullable<decimal> YearlyIncome { get; set; }
        }
    }
}
