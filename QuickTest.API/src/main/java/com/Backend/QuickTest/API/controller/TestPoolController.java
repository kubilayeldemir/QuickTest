package com.Backend.QuickTest.API.controller;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.service.TestPoolService;
import io.swagger.annotations.Api;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/api/testpool")
@Api(value = "Testpool Api documentation")
public class TestPoolController {
    private TestPoolService testPoolService;

    @Autowired
    public TestPoolController(TestPoolService testPoolService) {
        this.testPoolService = testPoolService;
    }

    @GetMapping
    public TestCase getOneTestFromPool() {
        var testCase = testPoolService.getOneTestCaseFromPool();
        if (testCase.isPresent()) {
            return testCase.get();
        }
        return null;
    }

}
