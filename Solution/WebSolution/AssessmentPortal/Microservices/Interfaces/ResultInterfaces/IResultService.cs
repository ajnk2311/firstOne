﻿using ResultEntity;
namespace ResultInterfaces;

public interface IResultService{
   
    public int GetCandidateTestScore(int candidateId, int testId);

    public bool SetCandidateTestStartTime(int candidateId, int testId, TestTime time);

    public bool SetCandidateTestEndTime(int candidateId, int testId, TestTime time);

    public CandidateResultDetails CandidateTestResultDetails(int candidateId, int testId);

    public List<TestResultDetails> GetTestResultDetails(int testId);
    public List<AppearedCandidate> GetAppearedCandidates(int testId);

    public List<PassedCandidateDetails> GetPassedCandidateResults(int testId);
    public List<FailedCandidateDetails> GetFailedCandidateResults(int testId);
}