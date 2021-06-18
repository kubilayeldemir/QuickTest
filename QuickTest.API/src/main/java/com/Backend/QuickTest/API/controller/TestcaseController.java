package com.Backend.QuickTest.API.controller;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.repository.TestcaseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/api/testcase")
public class TestcaseController {
    private TestcaseRepository testcaseRepository;

    @Autowired
    public TestcaseController(TestcaseRepository testcaseRepository){this.testcaseRepository = testcaseRepository; }

    @GetMapping
    public List<TestCase> getAllTests(){
        return testcaseRepository.findAll();
    }

    @PostMapping
    public TestCase saveTestcase(@RequestBody TestCase testCase){
        return testcaseRepository.save(testCase);
    }

    @GetMapping("/{testId}")
    public Optional<TestCase> getTestById(@PathVariable("testId") long testId){
        return testcaseRepository.findById(testId);
    }
}
