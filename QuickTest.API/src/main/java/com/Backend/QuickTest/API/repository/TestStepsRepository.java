package com.Backend.QuickTest.API.repository;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.model.TestStep;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface TestStepsRepository extends JpaRepository<TestStep,Long> {
}
