package com.Backend.QuickTest.API.service;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.repository.TestPoolRepository;
import com.Backend.QuickTest.API.repository.TestcaseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.Optional;

@Service
public class TestPoolService {
    private final TestPoolRepository testPoolRepository;
    private final TestcaseRepository testcaseRepository;

    @Autowired
    public TestPoolService(TestPoolRepository testPoolRepository, TestcaseRepository testcaseRepository) {
        this.testPoolRepository = testPoolRepository;
        this.testcaseRepository = testcaseRepository;
    }

    public Optional<TestCase> getOneTestCaseFromPool() {
        var testPoolTask = testPoolRepository.findTopBy();
        var testCase = testcaseRepository.findById(testPoolTask.getTestId());
        if (testCase.isPresent()) {
            testPoolRepository.deleteById(testPoolTask.getId());
        }
        return testCase;
    }
}
