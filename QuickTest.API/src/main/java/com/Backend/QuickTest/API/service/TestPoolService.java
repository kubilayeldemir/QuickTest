package com.Backend.QuickTest.API.service;

import com.Backend.QuickTest.API.exception.TestcaseNotFound;
import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.repository.TestPoolRepository;
import com.Backend.QuickTest.API.repository.TestcaseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

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

    @Transactional
    public Optional<TestCase> getOneTestCaseFromPool() {
        var testPoolTask = testPoolRepository.findTopBy();
        if (!testPoolTask.isPresent()) {
            throw new TestcaseNotFound();
        }
        var testCase = testcaseRepository.findById(testPoolTask.get().getTestId());
        if (!testCase.isPresent()) {
            throw new TestcaseNotFound();
        }
        testPoolRepository.deleteById(testPoolTask.get().getId());
        return testCase;
    }
}
