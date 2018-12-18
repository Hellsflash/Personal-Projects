namespace Todo.Web.Controllers
{
    using System.Web.Mvc;
    using Dto;
    using Repository.Contracts;
    using Repository.Implementations;

    public class HomeController : Controller
    {
        private readonly ITaskRepository _taskRepository;

        public HomeController(TaskRepository repository)
        {
            _taskRepository = repository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _taskRepository.GetAllTasks();
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Add()
        {           
            return View();
        }
        [HttpPost]
        public ActionResult Add(TaskDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            _taskRepository.AddTask(dto);
           return RedirectToAction("Index");
        }
    }
}