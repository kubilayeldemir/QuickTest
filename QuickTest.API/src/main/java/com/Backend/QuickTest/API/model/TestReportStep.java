package com.Backend.QuickTest.API.model;

import com.sun.istack.NotNull;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.util.Date;

@Entity
@Table(name="TestReportStep")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class TestReportStep {
    @Id
    @Column(name="StepResultId")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long reportStepId;

    @Column(name="stepDescription")
    private String stepDescription;

    @NotNull
    @Column(name="stepNumber")
    private int stepNumber;

    @Column(name="status")
    private boolean status;

    @Column(name="stepImageUrl")
    private String stepImageUrl;

    @Column(name="stepDate")
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date stepDate;
}


