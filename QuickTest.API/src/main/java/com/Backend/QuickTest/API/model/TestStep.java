package com.Backend.QuickTest.API.model;

import com.Backend.QuickTest.API.model.enums.Action;
import com.Backend.QuickTest.API.model.enums.FindElementBy;
import com.sun.istack.NotNull;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.core.annotation.Order;

import javax.persistence.*;

@Entity
@Table(name="TestStep")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class TestStep {
    @Id
    @Column(name="id")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    @NotNull
    @Column(name="stepNumber")
    private int stepNumber;

    @Column(name="elementAddress")
    private String elementAddress;

    @NotNull
    @Column(name="FindElementBy")
    @Enumerated(EnumType.STRING)
    private FindElementBy by;

    @Column(name="Action")
    @Enumerated(EnumType.STRING)
    private Action action;

    @Column(name="actionText")
    private String actionText;
}
