package com.Backend.QuickTest.API.model;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.util.Date;

@Entity
@Table(name = "TESTPOOL")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class TestPool {
    @Id
    @Column(name = "id")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "testId")
    private long TestId;
}
