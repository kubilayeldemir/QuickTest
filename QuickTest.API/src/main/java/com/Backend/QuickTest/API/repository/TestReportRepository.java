package com.Backend.QuickTest.API.repository;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.model.TestReport;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface TestReportRepository extends JpaRepository<TestReport,Long> {
    List<TestReport> findBytestcaseId(long testcaseId);
}
