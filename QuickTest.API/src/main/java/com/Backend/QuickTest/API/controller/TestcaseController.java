package com.Backend.QuickTest.API.controller;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.model.TestReport;
import com.Backend.QuickTest.API.repository.TestReportRepository;
import com.Backend.QuickTest.API.repository.TestcaseRepository;
import io.swagger.annotations.Api;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/api/testcase")
@Api(value = "Testcase Api documentation")
public class TestcaseController {
    private TestcaseRepository testcaseRepository;
    private TestReportRepository testReportRepository;

    @Autowired
    public TestcaseController(TestcaseRepository testcaseRepository, TestReportRepository testReportRepository) {
        this.testcaseRepository = testcaseRepository;
        this.testReportRepository = testReportRepository;
    }

    @GetMapping
    public List<TestCase> getAllTests() {
        return testcaseRepository.findAll();
    }

    @PostMapping
    public TestCase saveTestcase(@RequestBody TestCase testCase) {
        return testcaseRepository.save(testCase);
    }

    @GetMapping("/{testId}")
    public Optional<TestCase> getTestById(@PathVariable("testId") long testId) {
        return testcaseRepository.findById(testId);
    }

    @PostMapping("/reports")
    public TestReport saveReport(@RequestBody TestReport testReport) {
        return testReportRepository.save(testReport);
    }
    @GetMapping("/reports/{testCaseId}")
    public List<TestReport> getReportById(@PathVariable("testCaseId") long testCaseId) {
        return testReportRepository.findBytestcaseId(testCaseId);
    }
    @GetMapping("/reports")
    public List<TestReport> getAllReports() {
        return testReportRepository.findAll();
    }
}
