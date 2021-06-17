package com.Backend.QuickTest.API.repository;

import com.Backend.QuickTest.API.model.TestCase;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface TestcaseRepository extends JpaRepository<TestCase,Long> {
}
