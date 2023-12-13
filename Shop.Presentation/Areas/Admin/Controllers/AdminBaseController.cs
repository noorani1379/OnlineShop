
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace DaneshkarShop.Presentation.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]

public abstract class AdminBaseController : Controller
{
}
