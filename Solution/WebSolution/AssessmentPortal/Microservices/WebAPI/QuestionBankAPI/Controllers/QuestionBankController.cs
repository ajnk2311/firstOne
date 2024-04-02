using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using QuestionBankEntity; //-----------------------dll
using QuestionBankInterfaces;//-----------------------dll
using QuestionBankServices;//------------------------dll

//Controller is now responsible to handle HTTP Requests

[ApiController]
[Route("api/[controller]")]
public class QuestionBankController : ControllerBase
{ 
        public QuestionBankController()
        {
            // Initialize with some sample data
            
        }

        // GET: api/assessment

        IQuestionBankService  _svc = new QuestionBankService();
        
        
        [HttpGet]
        public IActionResult Get()
        {
          List<QuestionTitle> questions = _svc.GetAllQuestions();
            return Ok(questions);
        }

        // GET: api/assessments/{id}
        // [HttpGet("{id}")]
        // public IActionResult Get(int id)
        // {
        //     IAssessmentService _svc=new AssessmentService();
        //     Assessment theAssessment=_svc.GetDetails(id);
        //     return Ok(theAssessment);
        // }

        // POST: api/assessments
        [HttpPost]
        // public IActionResult Post()
        // {
        //     if (assessment == null)
        //         return BadRequest();
        //     // Generate a unique ID for the new assessment
        //     return CreatedAtAction(nameof(Get), new { id = assessment.Id }, assessment);
        // }

        // PUT: api/assessments/{id}
        [HttpPut("{id}")]
        // public IActionResult Put(int id, [FromBody] Assessment assessment)
        // {
        
        //     return NoContent();
        // }

        // DELETE: api/assessments/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            /*var assessment =  null;

            if (assessment == null)
                return NotFound();
            */
            return NoContent();
        }

}
