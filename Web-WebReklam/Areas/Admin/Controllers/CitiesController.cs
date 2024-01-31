﻿using ApplicationCore_WebReklam.DTO_s.CityDTO;
using ApplicationCore_WebReklam.Entities.Concrete;
using AutoMapper;
using Infrastructure_WebReklam.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_WebReklam.Areas.Admin.Models;

namespace Web_WebReklam.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class CitiesController : Controller
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CitiesController(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var cities = await _cityRepository.GetFilteredList
                (
                    select: x =>  new GetCityVM 
                    {
                        Id = x.Id,
                        Name = x.Name,
                        CreatedDate = x.CreatedDate,
                        UpdatedDate = x.UpdatedDate,
                        Status = x.Status
                    },
                    where: x => x.Status != ApplicationCore_WebReklam.Entities.Abstract.Status.Passive
                );

            return View(cities);
        }

        public IActionResult CreateCity() => View();

        [HttpPost]
        public async Task<IActionResult> CreateCity(CreateCityDTO model) 
        {
            if (ModelState.IsValid)
            {
                var city = _mapper.Map<City>(model);
                await _cityRepository.AddAsync(city);
                return RedirectToAction("Index");   
            }

            return View(model);
        }
    }
}
