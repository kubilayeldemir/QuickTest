package com.Backend.QuickTest.API.repository;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.model.enums.TimeCycle;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface TestcaseRepository extends JpaRepository<TestCase, Long> {
    TestCase findByCycleTimingByMinutes(TimeCycle CycleTimingByMinutes);

    List<TestCase> findAllByCycleTimingByMinutesAndActive(TimeCycle CycleTimingByMinutes, boolean Active);
}
