using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ResultEntity;
using ResultInterfaces;
using ResultServices;


[ApiController]
[Route("api/[controller]")]
public class ResultController : ControllerBase
{ 
        public ResultController()
        {
            
            
        }
        
     
        [HttpGet]
        public IActionResult Get()
        {
            return Ok( );
        }

        //get candidate score with storedprocedure .
        [HttpGet("candidates/{candidateId}/tests/{testId}/score")]
        public IActionResult GetCandidateScore(int candidateId, int testId)
        {   
            IResultService _svc = new ResultService();
            int result = _svc.GetCandidateTestScore(candidateId,testId);
            Console.WriteLine(result);
            return Ok(result);
        }
        

 
        //set starttime in the test .
        [HttpPost("setstarttime/{candidateId}/tests/{testId}")]
        public IActionResult SetCandidateTestStartTime(int candidateId, int testId, TestTime time)
         {   
            IResultService _svc = new ResultService();
            bool status = _svc.SetCandidateTestStartTime(candidateId,testId,time);
            return Ok(status);
        }



        //set endtime in the test .
        [HttpPut("setendtime/{candidateId}/tests/{testId}")]
        public IActionResult SetCandidateTestEndTime(int candidateId, int testId, TestTime time)
         {   
            IResultService _svc = new ResultService();
            bool status = _svc.SetCandidateTestEndTime(candidateId,testId,time);
            return Ok(status);
        }

        

        //get candidate details of test.
        [HttpGet("candidates/{candidateId}/tests/{testId}/details")]
        public IActionResult GetCandidatetResultDetails(int candidateId, int testId)
        {   
            IResultService _svc = new ResultService();
            CandidateResultDetails result = _svc.CandidateTestResultDetails(candidateId,testId);
            Console.WriteLine(result);
            return Ok(result);
        }



        //get test result details .
         [HttpGet("/tests/{testid}/details")]
        public IActionResult GetTestResultDetails(int testId)
        {   
            IResultService _svc = new ResultService();
            List<TestResultDetails> result = _svc.GetTestResultDetails(testId);
            return Ok(result);
        }



        //get appeared candidates of the test .
         [HttpGet("/candidates/tests/{testid}")]
         public IActionResult GetAppearedCandidates(int testId)
        {   
            IResultService _svc = new ResultService();
            List<AppearedCandidate> candidates = _svc.GetAppearedCandidates(testId);
            return Ok(candidates);
        }


        //get passed candidates of the test .
        [HttpGet("/passedcandidates/tests/{testId}")]
        public IActionResult GetPassedCandidate(int testId)
        {   
            IResultService _svc = new ResultService();
            List<PassedCandidateDetails> results = _svc.GetPassedCandidateResults(testId);
            Console.WriteLine(results);
            return Ok(results);
        }
         

         
       //get  failedcandidates of the test .
         [HttpGet("/failedcandidates/tests/{testId}")]
        public IActionResult GetFailedCandidate(int testId)
        {   
            IResultService _svc = new ResultService();
            List<FailedCandidateDetails> results = _svc.GetFailedCandidateResults(testId);
            Console.WriteLine(results);
            return Ok(results);
        }

       
        [HttpPut("/setpassinglevel/{testId}/passingLevel/{passingLevel}")]
        public IActionResult SetPassingLevel(int testId,int passingLevel)
        {   
            IResultService _svc = new ResultService();
            bool status = _svc.SetPassingLevel(testId,passingLevel);
            return Ok(status);
        }


          [HttpGet("/results/subjectresults/{subjectid}")]
        public IActionResult GetSubjectResultDetails(int subjectId)
        {   
            IResultService _svc = new ResultService();
            List<CandidateSubjectResults> results = _svc.GetSubjectResultDetails(subjectId);
            return Ok(results);
        }

        

}
