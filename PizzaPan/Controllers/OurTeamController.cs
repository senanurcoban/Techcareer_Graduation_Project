﻿using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.ValidationRules.OurTeamValidator;
using PizzaPan.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class OurTeamController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public OurTeamController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }
        public IActionResult Index()
        {
            var values = _ourTeamService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }

       
               
        public IActionResult DeleteOurTeam(int id)
        {
            var value = _ourTeamService.TGetByID(id);
            _ourTeamService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateOurTeam(int id)
        {
            var value = _ourTeamService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateOurTeam(OurTeam ourTeam)
        {
            _ourTeamService.TUpdate(ourTeam);
            return RedirectToAction("Index");
        }
    }
}
