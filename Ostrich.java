package evo.patterns;

import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;

/**
 * Annotation to be placed above methods or classes where the Ostrich pattern
 * has is applied.
 * The Ostrich patten is applied to situations where coding shortcuts are taken
 * that disregard corner cases or exceptional situations that 'should not' or
 * are 'unlikely to' happen. These shortcuts are taken by developers due to
 * unclear requirements, lack of time, laziness or incompetence.
 *
 * @author Eric van Orsouw
 */
@Retention(RetentionPolicy.RUNTIME)
public @interface Ostrich {

    /**
     * @return A brief description of the conditions that have been disregarded.
     */
    String disregard();
}
