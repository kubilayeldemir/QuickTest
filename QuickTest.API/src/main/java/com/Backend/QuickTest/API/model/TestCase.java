package com.Backend.QuickTest.API.model;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.List;

@Entity
@Table(name="TESTCASE")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class TestCase {
    @Id
    @Column(name="TestId")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    @Column(name="testName")
    private String testName;

    @Column(name="websiteAddress")
    private String websiteAddress;

    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
    @JoinColumn(name = "TestId")
    private List<TestStep> steps;

    @OneToMany(fetch = FetchType.LAZY, cascade = CascadeType.ALL)
    @JoinColumn(name = "TestId")
    private List<TestReport> testReports;

}
