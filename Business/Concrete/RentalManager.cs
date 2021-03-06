﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<Rental> GetByCarId(int carId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == carId));
        }
    

        public IDataResult<Rental> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.CustomerId == customerId));
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r =>r.Id == rentalId));
        }

        public IDataResult<Rental> GetByRentDate(DateTime rentDate)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentDate == rentDate));
        }

        public IDataResult<Rental> GetByReturndate(DateTime returndate)
        {
            var result = _rentalDal.Get(r => r.ReturnDate == null);
            if (result != null)
            {
                return new ErrorDataResult<Rental>(Messages.NotReturned);
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.ReturnDate == returndate));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
