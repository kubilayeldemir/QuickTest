package com.Backend.QuickTest.API.model;

import com.Backend.QuickTest.API.model.enums.TimeCycle;
import com.fasterxml.jackson.annotation.JsonIgnore;
import io.swagger.annotations.ApiModel;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.List;

@Entity
@Table(name = "TESTCASE")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
@ApiModel(value = "Testcase Api model documentation", description = "Model")
public class TestCase {
    @Id
    @Column(name = "TestId")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    @Column(name = "testName")
    private String testName;

    @Column(name = "websiteAddress")
    private String websiteAddress;

    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
    @JoinColumn(name = "TestId")
    private List<TestStep> steps;

    @OneToMany(mappedBy = "testCase", fetch = FetchType.LAZY)
    @JsonIgnore
    private List<TestReport> testReports;

    @Column(name = "critical")
    private Boolean critical;

    @Column(name = "activity")
    private Boolean active;

    @Column(name = "cycleTimingByMinutes")
    @Enumerated(EnumType.STRING)
    private TimeCycle cycleTimingByMinutes;
}
