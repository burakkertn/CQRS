﻿namespace Casgem_CQRS.CQRS.Results
{
    public class GetProductByIDQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductMark { get; set; }
    }
}
