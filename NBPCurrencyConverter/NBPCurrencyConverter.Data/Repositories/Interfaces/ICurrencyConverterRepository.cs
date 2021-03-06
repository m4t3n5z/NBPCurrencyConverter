﻿using NBPCurrencyConverter.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NBPCurrencyConverter.Data.Repositories.Interfaces
{
    public interface ICurrencyConverterRepository
    {
        Task AddOperationConvertInfoAsync(OperationConvertInfo operationConvertInfo); 
        Task AddOperationCurrencyRetrievesInfoAsync(OperationCurrencyRetrievesInfo operationCurrencyRetrievesInfo); 
    }
}
