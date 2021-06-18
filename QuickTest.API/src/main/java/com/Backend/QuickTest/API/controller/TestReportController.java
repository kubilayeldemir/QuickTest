package com.Backend.QuickTest.API.controller;

import com.Backend.QuickTest.API.model.TestReport;
import com.Backend.QuickTest.API.repository.TestReportRepository;
import io.swagger.annotations.Api;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

//@RestController
//@RequestMapping("/api/testreport")
//@Api(value = "TestReport documentation")
public class TestReportController {
    private TestReportRepository testReportRepository;

    @Autowired
    public TestReportController(TestReportRepository testReportRepository) {
        this.testReportRepository = testReportRepository;
    }

    @GetMapping
    public List<TestReport> getAllReports() {
        return testReportRepository.findAll();
    }

    @PostMapping
    public TestReport saveReport(@RequestBody TestReport testReport) {
        return testReportRepository.save(testReport);
    }
}
