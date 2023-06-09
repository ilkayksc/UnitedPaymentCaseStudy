﻿using System;
using UnitedPaymentCaseStudy.Data.Entity;

namespace UnitedPaymentCaseStudy.Business.Interfaces
{
    public interface IBaseService<Dto, Entity>
    {
        BaseResponse<Dto> GetById(long id);
        BaseResponse<IEnumerable<Dto>> GetAll();
        BaseResponse<Dto> Insert(Dto insertResource);
        BaseResponse<Dto> Update(long id, Dto updateResource);
        BaseResponse<Dto> Remove(long id);
    }
}

