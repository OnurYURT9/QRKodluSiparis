﻿using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        int TProductCount();
		int TProductCountByCategoryNameHamburger();
		int TProductCountByCategoryDrink();
		decimal TProductPriceAvg();
		string TProductNameByMaxPrice();
		string TProductNameByMinPrice();
		decimal TProductAvgPriceByHamburger();
	}
}
