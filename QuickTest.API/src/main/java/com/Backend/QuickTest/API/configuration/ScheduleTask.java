package com.Backend.QuickTest.API.configuration;

import com.Backend.QuickTest.API.model.TestCase;
import com.Backend.QuickTest.API.model.TestPool;
import com.Backend.QuickTest.API.model.enums.TimeCycle;
import com.Backend.QuickTest.API.repository.TestPoolRepository;
import com.Backend.QuickTest.API.repository.TestcaseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Configuration;
import org.springframework.scheduling.annotation.EnableScheduling;
import org.springframework.scheduling.annotation.Scheduled;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

@Configuration
@EnableScheduling
public class ScheduleTask {
    private final TestcaseRepository testcaseRepository;
    private final TestPoolRepository testPoolRepository;

    @Autowired
    public ScheduleTask(TestcaseRepository testcaseRepository, TestPoolRepository testPoolRepository) {
        this.testcaseRepository = testcaseRepository;
        this.testPoolRepository = testPoolRepository;
    }

    public List<TestPool> addTestsToPoolByTheirTimeCycle(TimeCycle timeCycle) {
        List<TestCase> listOfTests = testcaseRepository.findAllByCycleTimingByMinutesAndActive(timeCycle, true);
        List<TestPool> testPoolList = new ArrayList<TestPool>();
        for (var test : listOfTests) {
            TestPool testPool = new TestPool();
            testPool.setTestId(test.getId());
            testPoolList.add(testPool);
        }
        return testPoolRepository.saveAll(testPoolList);
    }

    @Scheduled(fixedDelay = 10000L)
    public void add10MinTestsToPool() {
        var addedTestsList = addTestsToPoolByTheirTimeCycle(TimeCycle.Every10Min);
        System.out.println("10Min tests added to pool. Number of Test:" + addedTestsList.size() + " Date:" + LocalDateTime.now().toString());
    }

    @Scheduled(fixedDelay = 20000L)
    public void add30MinTestsToPool() {
        var addedTestsList = addTestsToPoolByTheirTimeCycle(TimeCycle.Every30Min);
        System.out.println("30Min tests added to pool. Number of Test:" + addedTestsList.size() + " Date:" + LocalDateTime.now().toString());
    }

    @Scheduled(fixedDelay = 20000L)
    public void addEveryHourTestsToPool() {
        var addedTestsList = addTestsToPoolByTheirTimeCycle(TimeCycle.EveryHour);
        System.out.println("Every hour tests added to pool. Number of Test:" + addedTestsList.size() + " Date:" + LocalDateTime.now().toString());
    }
}
