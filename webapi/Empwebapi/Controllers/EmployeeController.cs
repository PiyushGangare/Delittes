using Dal;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using models.EmpEnt;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{[HttpGet]
[EnableCors()]
    public ActionResult<List<Employee>> GetEmployees(){
        
        return Ok(DBManager.GetAll());
    }
    [HttpGet]
    [Route("{id}")]
    public ActionResult<Employee> GetEmployee( int id){
        return Ok(DBManager.GetOne(id));
    }
    [HttpDelete]
    [Route("{id}")]
    public ActionResult DeleteEmployee(int id){
       DBManager.DeleteOne(id);
        return Ok();
    }
    [HttpPost]
    [EnableCors()]
    
    public ActionResult InsertEmployee(Employee Emp){
        DBManager.InsertOne(Emp);
        return Ok();
    }
    [HttpPut]
    [Route("{id}")]
    [EnableCors()]
    public ActionResult UpdateEmployee(int id ,Employee emp){
        DBManager.UpdateOne(id,emp);
        return Ok();
    }
}