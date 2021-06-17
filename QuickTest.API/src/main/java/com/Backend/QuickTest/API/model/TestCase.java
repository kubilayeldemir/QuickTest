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
    private int id;

    @Column(name="testName")
    private String testName;

    @OneToMany(fetch = FetchType.EAGER, cascade = CascadeType.ALL)
    @JoinColumn(name = "TestId")
    private List<TestStep> steps;


}
