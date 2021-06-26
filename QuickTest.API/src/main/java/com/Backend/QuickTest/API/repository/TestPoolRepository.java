package com.Backend.QuickTest.API.repository;

import com.Backend.QuickTest.API.model.TestPool;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface TestPoolRepository extends JpaRepository<TestPool, Long> {
}
