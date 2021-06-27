package com.Backend.QuickTest.API.exception;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.ResponseStatus;

@ResponseStatus(code = HttpStatus.NOT_FOUND, reason = "Testcase found")
public class TestcaseNotFound extends RuntimeException {
}

