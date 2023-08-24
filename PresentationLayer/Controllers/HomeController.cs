using AutoMapper;
using BusinessLayer.DTO;
using BusinessLayer.Services;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using PresentationLayer.Models.ViewModels;
using System.Diagnostics;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMemberService memberService)
        {
            _logger = logger;
            _memberService = memberService;
            _mapper = new MapperConfiguration(cfg => cfg.CreateMap<MemberDTO, MemberViewModel>()).CreateMapper();
        }

        public IActionResult Index()
        {
            var list = _mapper.Map<IEnumerable<MemberDTO>, List<MemberViewModel>>(_memberService.GetMembers());
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}