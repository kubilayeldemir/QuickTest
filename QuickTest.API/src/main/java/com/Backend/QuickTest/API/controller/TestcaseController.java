package com.Backend.QuickTest.API.controller;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.repository.TestcaseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

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

    @GetMapping("/{testId}")
    public Optional<TestCase> getTestById(@PathVariable long testId){
        return testcaseRepository.findById(testId);
    }
}
