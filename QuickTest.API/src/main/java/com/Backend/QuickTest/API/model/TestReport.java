package com.Backend.QuickTest.API.model;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Entity
@Table(name="TestReport")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class TestReport {
    @Id
    @Column(name="ReportId")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long reportId;

    @Column(name="status")
    private boolean status;

    @Column(name="errorMessage")
    private String errorMessage;

    @Column(name="logFileURL")
    private String logFileURL;

    @Column(name="testStartDate")
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date testStartDate;

    @Column(name="testEndDate")
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date testEndDate;

    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
    @JoinColumn(name = "ReportId")
    private List<TestReportStep> testSteps;
}
