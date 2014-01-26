﻿using System;
using Merchello.Core.Models;
using Merchello.Core.Models.Interfaces;

namespace Merchello.Web.Models.ContentEditing
{
    internal static class FullfillmentMappingExtensions
    {
        #region WarehouseDisplay

        internal static WarehouseDisplay ToWarehouseDisplay(this IWarehouse warehouse)
        {
            AutoMapper.Mapper.CreateMap<IWarehouse, WarehouseDisplay>();

            return AutoMapper.Mapper.Map<WarehouseDisplay>(warehouse);
        }

        #endregion

        #region IWarehouse

        internal static IWarehouse ToWarehouse(this WarehouseDisplay warehouseDisplay, IWarehouse destination)
        {
            if (warehouseDisplay.Key != Guid.Empty)
            {
                destination.Key = warehouseDisplay.Key;
            }
            destination.Name = warehouseDisplay.Name;
            destination.Address1 = warehouseDisplay.Address1;
            destination.Address2 = warehouseDisplay.Address2;
            destination.Locality = warehouseDisplay.Locality;
            destination.Region = warehouseDisplay.Region;
            destination.PostalCode = warehouseDisplay.PostalCode;
            destination.CountryCode = warehouseDisplay.CountryCode;
            destination.Phone = warehouseDisplay.Phone;
            destination.Email = warehouseDisplay.Email;
            destination.IsDefault = warehouseDisplay.IsDefault;

            return destination;
        }

        #endregion

        #region WarehouseInventoryDisplay

        internal static CatalogInventoryDisplay ToCatalogInventoryDisplay(this ICatalogInventory catalogInventory)
        {
            AutoMapper.Mapper.CreateMap<ICatalogInventory, CatalogInventoryDisplay>();

            return AutoMapper.Mapper.Map<CatalogInventoryDisplay>(catalogInventory);
        }

        #endregion

        #region IWarehouseInventory

        internal static ICatalogInventory ToCatalogInventory(this CatalogInventoryDisplay catalogInventoryDisplay, ICatalogInventory destination)
        {
            destination.Count = catalogInventoryDisplay.Count;
            destination.LowCount = catalogInventoryDisplay.LowCount;

            return destination;
        }

        #endregion

        #region ShipCountryDisplay

        internal static ShipCountryDisplay ToShipCountryDisplay(this IShipCountry shipCountry)
        {
            AutoMapper.Mapper.CreateMap<IShipCountry, ShipCountryDisplay>();

            return AutoMapper.Mapper.Map<ShipCountryDisplay>(shipCountry);
        }

        #endregion

        #region ShipGatewayProviderDisplay

        //internal static ShipGatewayProviderDisplay ToShipGatewayProviderDisplay(this IShipGatewayProvider shipGatewayProvider)
        //{
        //    AutoMapper.Mapper.CreateMap<IShipGatewayProvider, ShipGatewayProviderDisplay>();

        //    return AutoMapper.Mapper.Map<ShipGatewayProviderDisplay>(shipGatewayProvider);
        //}

        #endregion

        #region ShipMethodDisplay

        internal static ShipMethodDisplay ToShipMethodDisplay(this IShipMethod shipMethod)
        {
            AutoMapper.Mapper.CreateMap<IShipMethod, ShipMethodDisplay>();

            return AutoMapper.Mapper.Map<ShipMethodDisplay>(shipMethod);
        }

        #endregion

        #region ShipProvinceDisplay

        internal static ShipProvinceDisplay ToShipProvinceDisplay(this IShipProvince shipProvince)
        {
            AutoMapper.Mapper.CreateMap<IShipProvince, ShipProvinceDisplay>();

            return AutoMapper.Mapper.Map<ShipProvinceDisplay>(shipProvince);
        }

        #endregion

        #region TaxProvinceDisplay

        internal static TaxProvinceDisplay ToTaxProvinceDisplay(this CountryTaxRate countryTaxRate)
        {
            AutoMapper.Mapper.CreateMap<CountryTaxRate, TaxProvinceDisplay>();

            return AutoMapper.Mapper.Map<TaxProvinceDisplay>(countryTaxRate);
        }

        #endregion
    }
}
